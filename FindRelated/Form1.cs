﻿/*
 *                                FindRelated
 *              Copyright © 2003-2019 Stellman & Greene Consulting
 *      Developed for Joshua Zivin and Pierre Azoulay, Columbia University
 *            http://www.stellman-greene.com/PublicationHarvester
 *
 * This program is free software; you can redistribute it and/or modify it under
 * the terms of the GNU General Public License as published by the Free Software 
 * Foundation; either version 2 of the License, or (at your option) any later 
 * version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT 
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
 * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along with 
 * this program (GPL.txt); if not, write to the Free Software Foundation, Inc., 51 
 * Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using Com.StellmanGreene.PubMed;
using PubMed;

namespace Com.StellmanGreene.FindRelated
{
    public partial class Form1 : Form
    {
        private static readonly char[] INCLUDE_SEPARATORS = new char[] { ';', ',', ' ', '|' };

        /// <summary>
        /// Currently entered include categories
        /// </summary>
        private readonly IEnumerable<int> includeCategoriesValues = new List<int>();

        private readonly Color _dsnBackColor;
        private readonly Color _inputFileTextBoxBackColor;
        private readonly Color _outputFileTextBoxBackColor;
        private readonly Color _relatedTableBackColor;
        private readonly Color _warningBackColor = Color.FromArgb(254, 180, 180);

        public Form1()
        {
            InitializeComponent();

            _dsnBackColor = DSN.BackColor;
            _inputFileTextBoxBackColor = inputFileTextBox.BackColor;
            _outputFileTextBoxBackColor = outputFileTextBox.BackColor;
            _relatedTableBackColor = relatedTable.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get saved settings
            relatedTable.Text = Settings.GetValueString("FindRelated_RelatedTable", "relatedpublications");
            inputFileTextBox.Text = Settings.GetValueString("FindRelated_InputFile", "findrelated_input.csv");
            apiKeyFileTextBox.Text = Settings.GetValueString("FindRelated_ApiKeyFile", "");

            // Set up the log
            logFilename.Text = Environment.GetEnvironmentVariable("TEMP") + @"\FindRelated_log.txt";
            TraceListener listBoxListener = new ListBoxTraceListener(log, toolStripStatusLabel1);
            Trace.Listeners.Add(new TextWriterTraceListener(logFilename.Text));
            Trace.Listeners.Add(listBoxListener);
            Trace.AutoFlush = true;

            // Add the version to the status bar
            Text += " v" + Application.ProductVersion;

            GetODBCDataSourceNames();

            Trace.WriteLine("----------------------------------------------------------");
            Trace.WriteLine(DateTime.Now + " - " + this.Text + " started");

            CheckFieldsAndEnableButtons();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save settings
            Settings.SetValue("FindRelated_RelatedTable", relatedTable.Text);
            Settings.SetValue("FindRelated_InputFile", inputFileTextBox.Text);
            Settings.SetValue("FindRelated_ApiKeyFile", apiKeyFileTextBox.Text);

            Trace.WriteLine(DateTime.Now + " - form closed (stopping any currently running jobs)");
            backgroundWorker1.CancelAsync();
        }

        #region ODBC Data Source Dropdown
        /// <summary>
        /// Repopulate the DSN list when the user clicks on the DSN listbox
        /// </summary>
        private void DSN_Click(object sender, EventArgs e)
        {
            // Re-retrieve all of the DSNs
            GetODBCDataSourceNames();
        }

        /// <summary>
        /// Retrieve the ODBC DSNs from the registry and populate the DSN dropdown listbox
        /// </summary>
        public void GetODBCDataSourceNames()
        {
            string DropDownListText = DSN.Text;
            string str;
            RegistryKey rootKey;
            RegistryKey subKey;
            string[] dsnList;
            DSN.Items.Clear();
            rootKey = Registry.LocalMachine;
            str = "SOFTWARE\\\\ODBC\\\\ODBC.INI\\\\ODBC Data Sources";
            subKey = rootKey.OpenSubKey(str);
            if (subKey != null)
            {
                dsnList = subKey.GetValueNames();
                DSN.Items.Add("System DSNs");
                DSN.Items.Add("================");

                foreach (string dsnName in dsnList)
                {
                    DSN.Items.Add(dsnName);
                }
                subKey.Close();
            }
            rootKey.Close();
            rootKey = Registry.CurrentUser;
            str = "SOFTWARE\\\\ODBC\\\\ODBC.INI\\\\ODBC Data Sources";
            subKey = rootKey.OpenSubKey(str);
            dsnList = subKey.GetValueNames();
            if (subKey != null)
            {
                DSN.Items.Add("================");
                DSN.Items.Add("User DSNs");
                DSN.Items.Add("================");
                foreach (string dsnName in dsnList)
                {
                    DSN.Items.Add(dsnName);
                }
                subKey.Close();
            }
            rootKey.Close();
            DSN.Text = DropDownListText;
        }

        /// <summary>
        /// Implement the "..." button to pop up the ODBC administrator (odbcad32.exe)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ODBCPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "odbcad32.exe";
            proc.Start();
        }
        #endregion

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!SetApiKeyFromFormField()) return;

            if (String.IsNullOrWhiteSpace(outputFileTextBox.Text))
            {
                MessageBox.Show("Please specify an output filename. This file will be overwritten.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"The table '{relatedTable.Text}_queue' will be deleted and recreated if it exists.",
                    "Overwrite table?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.OK)
                {
                    // Start the run
                    backgroundWorker1.RunWorkerAsync(new Dictionary<string, object>() {
                        { "dsn", DSN.Text.Trim() },
                        { "relatedTableName", relatedTable.Text.Trim() },
                        { "inputFileInfo", new FileInfo(inputFileTextBox.Text.Trim()) },
                        { "resume", false },
                        { "outputFilename", outputFileTextBox.Text },
                    });

                    startButton.Enabled = false;
                    resumeButton.Enabled = false;
                    stopButton.Enabled = true;
                }
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(outputFileTextBox.Text))
            {
                MessageBox.Show("Please specify an output filename. This file will be appended (not overwritten).");
            }
            else
            {
                // Start the run
                backgroundWorker1.RunWorkerAsync(new Dictionary<string, object>() {
                    { "dsn", DSN.Text.Trim() },
                    { "relatedTableName", relatedTable.Text },
                    { "inputFileInfo", null},
                    { "resume", true },
                    { "outputFilename", outputFileTextBox.Text },
                });

                stopButton.Enabled = true;
                startButton.Enabled = false;
                resumeButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(DateTime.Now + " - stopping, please wait for the current operation to finish...");
            backgroundWorker1.CancelAsync();
        }

        private void inputFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = inputFileTextBox.Text;
            openFileDialog.Filter = "Comma-delimited Text Files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Select the input file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            inputFileTextBox.Text = openFileDialog.FileName;
        }

        /// <summary>
        /// Open the log in Notepad
        /// </summary>
        private void openInNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "notepad.exe";
            proc.StartInfo.Arguments = logFilename.Text;
            proc.Start();
        }

        /// <summary>
        /// Check ODBC DSN, related table, and input and output files, 
        /// give warnings if they're not filled in correctly, and
        /// enable or disable the start and resume buttons
        /// </summary>
        private void CheckFieldsAndEnableButtons()
        {
            string dsn = DSN.Text;
            string relatedTableName = relatedTable.Text;

            DSN.BackColor = _dsnBackColor;
            inputFileTextBox.BackColor = _inputFileTextBoxBackColor;
            outputFileTextBox.BackColor = _outputFileTextBoxBackColor;
            relatedTable.BackColor = _relatedTableBackColor;

            if (String.IsNullOrWhiteSpace(dsn) || dsn.StartsWith("==") || dsn.EndsWith("DSNs"))
            {
                DSN.BackColor = _warningBackColor;
                Trace.WriteLine($"{DateTime.Now} - Please select a valid ODBC data source");
                startButton.Enabled = false;
                resumeButton.Enabled = false;
            }
            else if (String.IsNullOrWhiteSpace(relatedTableName))
            {
                relatedTable.BackColor = _warningBackColor;
                Trace.WriteLine($"{DateTime.Now} - Please specify a related table");
                startButton.Enabled = false;
                resumeButton.Enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(inputFileTextBox.Text))
            {
                inputFileTextBox.BackColor = _warningBackColor;
                Trace.WriteLine($"{DateTime.Now} - Please select a valid input file");
                startButton.Enabled = false;
                resumeButton.Enabled = false;
            }
            else if (!new FileInfo(inputFileTextBox.Text).Exists)
            {
                inputFileTextBox.BackColor = _warningBackColor;
                Trace.WriteLine($"{DateTime.Now} - Please select a valid input file");
                startButton.Enabled = false;
                resumeButton.Enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(outputFileTextBox.Text))
            {
                outputFileTextBox.BackColor = _warningBackColor;
                Trace.WriteLine($"{DateTime.Now} - Please select an output filename");
                startButton.Enabled = false;
                resumeButton.Enabled = false;
            }
            else
            {
                startButton.Enabled = true;
                var unprocessedPMIDCount = GetUnprocessedPMIDCount();
                resumeButton.Enabled = (unprocessedPMIDCount > 0);
            }
        }

        /// <summary>
        /// Last _queue table checked for unprocessed PMIDs (to avoid duplicate log entries)
        /// </summary>
        private string _lastQueueTableChecked = "";

        /// <summary>
        /// Checks if there are unprocessed PMIDs from the queue table,
        /// sets the Resume button, and prints a message (avoiding 
        /// duplicates from checking the same table multiple times)
        /// </summary>
        private long GetUnprocessedPMIDCount()
        {
            string dsn = DSN.Text;
            if (string.IsNullOrWhiteSpace(dsn) || dsn.StartsWith("==") || dsn.EndsWith("DSNs") || string.IsNullOrWhiteSpace(relatedTable.Text))
            {
                return 0;
            }
            else
            {
                var queueTableName = relatedTable.Text + "_queue";
                try
                {
                    var db = new Database(dsn);

                    var tableExists = db.ExecuteScalar($"SHOW TABLES LIKE '{queueTableName}'");
                    if (tableExists == null)
                    {
                        if (_lastQueueTableChecked != queueTableName)
                        {
                            Trace.WriteLine($"{DateTime.Now} - no previous run for table {relatedTable.Text.Trim()} was found");
                            Trace.WriteLine($"{DateTime.Now} - Disabling Resume button");
                            _lastQueueTableChecked = queueTableName;
                        }
                        return 0;
                    }

                    var unprocessedPmidCount = (long)db.ExecuteScalar($"SELECT COUNT(*) FROM {queueTableName} WHERE Processed = 0");

                    if (_lastQueueTableChecked != queueTableName)
                    {
                        int queueSize = db.GetIntValue($"SELECT Count(*) FROM {queueTableName} WHERE Processed = 0 OR Error = 1");
                        string message = $"{DateTime.Now} - {queueSize} unprocessed PMIDs in table {relatedTable.Text.Trim()}";
                        int errors = db.GetIntValue("SELECT Count(*) FROM " + relatedTable.Text + "_queue WHERE Error = 1");
                        if (errors > 0)
                            message += " (including " + errors + " errors)";
                        Trace.WriteLine(message);

                        var enDis = (unprocessedPmidCount > 0) ? "En" : "Dis";
                        Trace.WriteLine($"{DateTime.Now} {enDis}abling Resume button");
                        _lastQueueTableChecked = queueTableName;
                    }

                    return unprocessedPmidCount;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine($"{DateTime.Now} Database getting unprocessed PMID count in {queueTableName}: {ex.Message}");
                    return 0;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Trace.WriteLine(DateTime.Now + " - started run");
            Dictionary<string, object> args = e.Argument as Dictionary<string, object>;
            RelatedFinder relatedFinder = new RelatedFinder() { BackgroundWorker = backgroundWorker1 };
            relatedFinder.Go(args["dsn"] as string,
                args["relatedTableName"] as string,
                args["inputFileInfo"] as FileInfo,
                (bool)args["resume"],
                args["outputFilename"] as string);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CheckFieldsAndEnableButtons();
            stopButton.Enabled = false;
            Trace.WriteLine(DateTime.Now + " - finished run");
        }

        private void outputFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = outputFileTextBox.Text;
            saveFileDialog.Filter = "Comma-delimited Text Files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Select the output file to save";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.OverwritePrompt = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            outputFileTextBox.Text = saveFileDialog.FileName;
        }

        private void relatedTable_TextChanged(object sender, EventArgs e)
        {
            CheckFieldsAndEnableButtons();
        }

        private void DSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFieldsAndEnableButtons();
        }

        private void DSN_Leave(object sender, EventArgs e)
        {
            CheckFieldsAndEnableButtons();
        }

        private void OutputFileTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFieldsAndEnableButtons();
        }

        private void InputFileTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFieldsAndEnableButtons();
        }


        /// <summary>
        /// Sets the NCBI API key from the field on the form
        /// </summary>
        /// <returns>
        /// True if the API key file in the field is found or empty, false if the API it's invalid
        /// </returns>
        private bool SetApiKeyFromFormField()
        {
            if (!string.IsNullOrWhiteSpace(apiKeyFileTextBox.Text.Trim()))
            {
                if (File.Exists(apiKeyFileTextBox.Text.Trim()))
                {
                    NCBI.GetApiKey(apiKeyFileTextBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show($"API key file not found: {apiKeyFileTextBox.Text.Trim()}");
                    return false;
                }
            }


            if (NCBI.ApiKeyExists)
            {
                Trace.WriteLine("Using API key: " + NCBI.ApiKeyPath);
            }
            else
            {
                Trace.WriteLine("Performance is limited to under 3 requests per second.");
                Trace.WriteLine("Consider pasting an API key into " + NCBI.ApiKeyPath);
                Trace.WriteLine("Or set the NCBI_API_KEY_FILE environemnt variable to the API key file path");
                Trace.WriteLine("For more information, see https://ncbiinsights.ncbi.nlm.nih.gov/2017/11/02/new-api-keys-for-the-e-utilities/");
            }

            return true;
        }

        private void ApiKeyFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = apiKeyFileTextBox.Text;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select API key file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            apiKeyFileTextBox.Text = openFileDialog.FileName;
        }
    }
}