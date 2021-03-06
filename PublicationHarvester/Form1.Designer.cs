namespace PublicationHarvester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ODBCPanel = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.DSN = new System.Windows.Forms.ComboBox();
            this.HarvestPublications = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.PeopleFile = new System.Windows.Forms.TextBox();
            this.PeopleFileDialog = new System.Windows.Forms.Button();
            this.PublicationTypeFileDialog = new System.Windows.Forms.Button();
            this.PublicationTypeFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenInNotepad = new System.Windows.Forms.Button();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LogFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemovePeople = new System.Windows.Forms.Button();
            this.AddUpdatePeople = new System.Windows.Forms.Button();
            this.UpdateStatusDuringHarvest = new System.Windows.Forms.CheckBox();
            this.PeopleNotHarvested = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PeopleWithErrors = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ResumeHarvesting = new System.Windows.Forms.Button();
            this.PublicationsFound = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PeopleHarvested = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.People = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TablesCreated = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HarvestingReports = new System.Windows.Forms.Button();
            this.Interrupt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LanguageList = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CheckForInterruptedData = new System.Windows.Forms.CheckBox();
            this.ApiKeyFileButton = new System.Windows.Forms.Button();
            this.ApiKeyFile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ODBCPanel
            // 
            this.ODBCPanel.AutoEllipsis = true;
            this.ODBCPanel.Location = new System.Drawing.Point(639, 35);
            this.ODBCPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ODBCPanel.Name = "ODBCPanel";
            this.ODBCPanel.Size = new System.Drawing.Size(24, 29);
            this.ODBCPanel.TabIndex = 130;
            this.ODBCPanel.Text = "...";
            this.ODBCPanel.Click += new System.EventHandler(this.ODBCPanel_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(14, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(243, 29);
            this.Label2.TabIndex = 110;
            this.Label2.Text = "&ODBC Data Source Name";
            // 
            // DSN
            // 
            this.DSN.FormattingEnabled = true;
            this.DSN.Location = new System.Drawing.Point(14, 32);
            this.DSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DSN.Name = "DSN";
            this.DSN.Size = new System.Drawing.Size(615, 28);
            this.DSN.TabIndex = 120;
            this.DSN.SelectedIndexChanged += new System.EventHandler(this.DSN_SelectedIndexChanged);
            this.DSN.Click += new System.EventHandler(this.DSN_Click);
            // 
            // HarvestPublications
            // 
            this.HarvestPublications.Location = new System.Drawing.Point(16, 269);
            this.HarvestPublications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HarvestPublications.Name = "HarvestPublications";
            this.HarvestPublications.Size = new System.Drawing.Size(252, 35);
            this.HarvestPublications.TabIndex = 10;
            this.HarvestPublications.Text = "&Harvest Publications";
            this.HarvestPublications.UseVisualStyleBackColor = true;
            this.HarvestPublications.Click += new System.EventHandler(this.HarvestPublications_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 140;
            this.label1.Text = "&People file";
            // 
            // PeopleFile
            // 
            this.PeopleFile.Location = new System.Drawing.Point(14, 99);
            this.PeopleFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeopleFile.Name = "PeopleFile";
            this.PeopleFile.Size = new System.Drawing.Size(739, 26);
            this.PeopleFile.TabIndex = 150;
            this.PeopleFile.TextChanged += new System.EventHandler(this.PeopleFile_TextChanged);
            // 
            // PeopleFileDialog
            // 
            this.PeopleFileDialog.AutoEllipsis = true;
            this.PeopleFileDialog.Location = new System.Drawing.Point(759, 98);
            this.PeopleFileDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeopleFileDialog.Name = "PeopleFileDialog";
            this.PeopleFileDialog.Size = new System.Drawing.Size(24, 29);
            this.PeopleFileDialog.TabIndex = 160;
            this.PeopleFileDialog.Text = "...";
            this.PeopleFileDialog.Click += new System.EventHandler(this.PeopleFileDialog_Click);
            // 
            // PublicationTypeFileDialog
            // 
            this.PublicationTypeFileDialog.AutoEllipsis = true;
            this.PublicationTypeFileDialog.Location = new System.Drawing.Point(759, 165);
            this.PublicationTypeFileDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublicationTypeFileDialog.Name = "PublicationTypeFileDialog";
            this.PublicationTypeFileDialog.Size = new System.Drawing.Size(24, 29);
            this.PublicationTypeFileDialog.TabIndex = 178;
            this.PublicationTypeFileDialog.Text = "...";
            this.PublicationTypeFileDialog.Click += new System.EventHandler(this.PublicationTypeFileDialog_Click);
            // 
            // PublicationTypeFile
            // 
            this.PublicationTypeFile.Location = new System.Drawing.Point(14, 165);
            this.PublicationTypeFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublicationTypeFile.Name = "PublicationTypeFile";
            this.PublicationTypeFile.Size = new System.Drawing.Size(739, 26);
            this.PublicationTypeFile.TabIndex = 174;
            this.PublicationTypeFile.TextChanged += new System.EventHandler(this.PublicationTypeFile_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 170;
            this.label3.Text = "Publication &type file";
            // 
            // Log
            // 
            this.Log.FormattingEnabled = true;
            this.Log.HorizontalScrollbar = true;
            this.Log.ItemHeight = 20;
            this.Log.Location = new System.Drawing.Point(17, 671);
            this.Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(769, 204);
            this.Log.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 29);
            this.label4.TabIndex = 90;
            this.label4.Text = "Log";
            // 
            // OpenInNotepad
            // 
            this.OpenInNotepad.Enabled = false;
            this.OpenInNotepad.Location = new System.Drawing.Point(629, 618);
            this.OpenInNotepad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenInNotepad.Name = "OpenInNotepad";
            this.OpenInNotepad.Size = new System.Drawing.Size(158, 31);
            this.OpenInNotepad.TabIndex = 80;
            this.OpenInNotepad.Text = "Open in &Notepad";
            this.OpenInNotepad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpenInNotepad.UseVisualStyleBackColor = true;
            this.OpenInNotepad.Click += new System.EventHandler(this.OpenInNotepad_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 24);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(547, 25);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 943);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(793, 32);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 25);
            this.toolStripStatusLabel2.Text = "Version";
            // 
            // LogFilename
            // 
            this.LogFilename.Location = new System.Drawing.Point(17, 620);
            this.LogFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogFilename.Name = "LogFilename";
            this.LogFilename.ReadOnly = true;
            this.LogFilename.Size = new System.Drawing.Size(604, 26);
            this.LogFilename.TabIndex = 70;
            this.LogFilename.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 29);
            this.label5.TabIndex = 60;
            this.label5.Text = "&Log file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemovePeople);
            this.groupBox1.Controls.Add(this.AddUpdatePeople);
            this.groupBox1.Controls.Add(this.UpdateStatusDuringHarvest);
            this.groupBox1.Controls.Add(this.PeopleNotHarvested);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PeopleWithErrors);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ResumeHarvesting);
            this.groupBox1.Controls.Add(this.PublicationsFound);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PeopleHarvested);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.People);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TablesCreated);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 309);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(766, 211);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Status";
            // 
            // RemovePeople
            // 
            this.RemovePeople.Location = new System.Drawing.Point(572, 91);
            this.RemovePeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemovePeople.Name = "RemovePeople";
            this.RemovePeople.Size = new System.Drawing.Size(174, 35);
            this.RemovePeople.TabIndex = 77;
            this.RemovePeople.Text = "Remove People";
            this.RemovePeople.UseVisualStyleBackColor = true;
            this.RemovePeople.Click += new System.EventHandler(this.RemovePeople_Click);
            // 
            // AddUpdatePeople
            // 
            this.AddUpdatePeople.Location = new System.Drawing.Point(390, 91);
            this.AddUpdatePeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUpdatePeople.Name = "AddUpdatePeople";
            this.AddUpdatePeople.Size = new System.Drawing.Size(174, 35);
            this.AddUpdatePeople.TabIndex = 76;
            this.AddUpdatePeople.Text = "Add/Update People";
            this.AddUpdatePeople.UseVisualStyleBackColor = true;
            this.AddUpdatePeople.Click += new System.EventHandler(this.AddUpdatePeopleFile_Click);
            // 
            // UpdateStatusDuringHarvest
            // 
            this.UpdateStatusDuringHarvest.AutoSize = true;
            this.UpdateStatusDuringHarvest.Checked = true;
            this.UpdateStatusDuringHarvest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpdateStatusDuringHarvest.Location = new System.Drawing.Point(369, 179);
            this.UpdateStatusDuringHarvest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateStatusDuringHarvest.Name = "UpdateStatusDuringHarvest";
            this.UpdateStatusDuringHarvest.Size = new System.Drawing.Size(377, 24);
            this.UpdateStatusDuringHarvest.TabIndex = 75;
            this.UpdateStatusDuringHarvest.Text = "Update these status numbers during the harvest";
            this.UpdateStatusDuringHarvest.UseVisualStyleBackColor = true;
            this.UpdateStatusDuringHarvest.CheckedChanged += new System.EventHandler(this.UpdateStatusDuringHarvest_CheckedChanged);
            // 
            // PeopleNotHarvested
            // 
            this.PeopleNotHarvested.Location = new System.Drawing.Point(210, 140);
            this.PeopleNotHarvested.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeopleNotHarvested.Name = "PeopleNotHarvested";
            this.PeopleNotHarvested.ReadOnly = true;
            this.PeopleNotHarvested.Size = new System.Drawing.Size(174, 26);
            this.PeopleNotHarvested.TabIndex = 74;
            this.PeopleNotHarvested.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 73;
            this.label10.Text = "People Not Harvested";
            // 
            // PeopleWithErrors
            // 
            this.PeopleWithErrors.Location = new System.Drawing.Point(28, 140);
            this.PeopleWithErrors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeopleWithErrors.Name = "PeopleWithErrors";
            this.PeopleWithErrors.ReadOnly = true;
            this.PeopleWithErrors.Size = new System.Drawing.Size(174, 26);
            this.PeopleWithErrors.TabIndex = 72;
            this.PeopleWithErrors.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "People With Errors";
            // 
            // ResumeHarvesting
            // 
            this.ResumeHarvesting.Enabled = false;
            this.ResumeHarvesting.Location = new System.Drawing.Point(390, 132);
            this.ResumeHarvesting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResumeHarvesting.Name = "ResumeHarvesting";
            this.ResumeHarvesting.Size = new System.Drawing.Size(356, 35);
            this.ResumeHarvesting.TabIndex = 50;
            this.ResumeHarvesting.Text = "Clear Errors and &Resume Previous Harvesting";
            this.ResumeHarvesting.UseVisualStyleBackColor = true;
            this.ResumeHarvesting.Click += new System.EventHandler(this.ResumeHarvesting_Click);
            // 
            // PublicationsFound
            // 
            this.PublicationsFound.Location = new System.Drawing.Point(572, 55);
            this.PublicationsFound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublicationsFound.Name = "PublicationsFound";
            this.PublicationsFound.ReadOnly = true;
            this.PublicationsFound.Size = new System.Drawing.Size(174, 26);
            this.PublicationsFound.TabIndex = 69;
            this.PublicationsFound.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "Publications Found";
            // 
            // PeopleHarvested
            // 
            this.PeopleHarvested.Location = new System.Drawing.Point(390, 55);
            this.PeopleHarvested.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeopleHarvested.Name = "PeopleHarvested";
            this.PeopleHarvested.ReadOnly = true;
            this.PeopleHarvested.Size = new System.Drawing.Size(174, 26);
            this.PeopleHarvested.TabIndex = 67;
            this.PeopleHarvested.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "People Harvested";
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(210, 55);
            this.People.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.People.Name = "People";
            this.People.ReadOnly = true;
            this.People.Size = new System.Drawing.Size(174, 26);
            this.People.TabIndex = 65;
            this.People.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "People";
            // 
            // TablesCreated
            // 
            this.TablesCreated.Location = new System.Drawing.Point(28, 55);
            this.TablesCreated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablesCreated.Name = "TablesCreated";
            this.TablesCreated.ReadOnly = true;
            this.TablesCreated.Size = new System.Drawing.Size(174, 26);
            this.TablesCreated.TabIndex = 63;
            this.TablesCreated.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tables Created";
            // 
            // HarvestingReports
            // 
            this.HarvestingReports.Location = new System.Drawing.Point(273, 269);
            this.HarvestingReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HarvestingReports.Name = "HarvestingReports";
            this.HarvestingReports.Size = new System.Drawing.Size(252, 35);
            this.HarvestingReports.TabIndex = 20;
            this.HarvestingReports.Text = "&Generate Harvesting Reports";
            this.HarvestingReports.UseVisualStyleBackColor = true;
            this.HarvestingReports.Click += new System.EventHandler(this.HarvestingReports_Click);
            // 
            // Interrupt
            // 
            this.Interrupt.Location = new System.Drawing.Point(530, 269);
            this.Interrupt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Interrupt.Name = "Interrupt";
            this.Interrupt.Size = new System.Drawing.Size(252, 35);
            this.Interrupt.TabIndex = 30;
            this.Interrupt.Text = "&Interrupt Current Harvest";
            this.Interrupt.UseVisualStyleBackColor = true;
            this.Interrupt.Click += new System.EventHandler(this.Interrupt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 191;
            this.button1.Text = "&About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.About_Click);
            // 
            // LanguageList
            // 
            this.LanguageList.Location = new System.Drawing.Point(16, 546);
            this.LanguageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LanguageList.Name = "LanguageList";
            this.LanguageList.Size = new System.Drawing.Size(768, 26);
            this.LanguageList.TabIndex = 193;
            this.LanguageList.Text = "eng";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 522);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(764, 29);
            this.label12.TabIndex = 192;
            this.label12.Text = "Languages (list of Medline language abbreviations separated by commas, blank for " +
    "no restriction)";
            // 
            // CheckForInterruptedData
            // 
            this.CheckForInterruptedData.AutoSize = true;
            this.CheckForInterruptedData.Checked = true;
            this.CheckForInterruptedData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckForInterruptedData.Location = new System.Drawing.Point(542, 579);
            this.CheckForInterruptedData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckForInterruptedData.Name = "CheckForInterruptedData";
            this.CheckForInterruptedData.Size = new System.Drawing.Size(220, 24);
            this.CheckForInterruptedData.TabIndex = 194;
            this.CheckForInterruptedData.Text = "Check for interrupted data";
            this.CheckForInterruptedData.UseVisualStyleBackColor = true;
            // 
            // ApiKeyFileButton
            // 
            this.ApiKeyFileButton.AutoEllipsis = true;
            this.ApiKeyFileButton.Location = new System.Drawing.Point(759, 228);
            this.ApiKeyFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApiKeyFileButton.Name = "ApiKeyFileButton";
            this.ApiKeyFileButton.Size = new System.Drawing.Size(24, 29);
            this.ApiKeyFileButton.TabIndex = 188;
            this.ApiKeyFileButton.Text = "...";
            this.ApiKeyFileButton.Click += new System.EventHandler(this.ApiKeyFileButton_Click);
            // 
            // ApiKeyFile
            // 
            this.ApiKeyFile.Location = new System.Drawing.Point(14, 228);
            this.ApiKeyFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApiKeyFile.Name = "ApiKeyFile";
            this.ApiKeyFile.Size = new System.Drawing.Size(739, 26);
            this.ApiKeyFile.TabIndex = 184;
            this.ApiKeyFile.TextChanged += new System.EventHandler(this.ApiKeyFile_TextChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(14, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 29);
            this.label13.TabIndex = 180;
            this.label13.Text = "API &key file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 975);
            this.Controls.Add(this.ApiKeyFileButton);
            this.Controls.Add(this.ApiKeyFile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CheckForInterruptedData);
            this.Controls.Add(this.LanguageList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Interrupt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HarvestingReports);
            this.Controls.Add(this.LogFilename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OpenInNotepad);
            this.Controls.Add(this.PublicationTypeFileDialog);
            this.Controls.Add(this.PublicationTypeFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PeopleFileDialog);
            this.Controls.Add(this.PeopleFile);
            this.Controls.Add(this.HarvestPublications);
            this.Controls.Add(this.DSN);
            this.Controls.Add(this.ODBCPanel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Publication Harvester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ODBCPanel;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox DSN;
        private System.Windows.Forms.Button HarvestPublications;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PeopleFile;
        internal System.Windows.Forms.Button PeopleFileDialog;
        internal System.Windows.Forms.Button PublicationTypeFileDialog;
        private System.Windows.Forms.TextBox PublicationTypeFile;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Log;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenInNotepad;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TextBox LogFilename;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PublicationsFound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PeopleHarvested;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox People;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TablesCreated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResumeHarvesting;
        private System.Windows.Forms.Button HarvestingReports;
        private System.Windows.Forms.TextBox PeopleNotHarvested;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PeopleWithErrors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Interrupt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox UpdateStatusDuringHarvest;
        private System.Windows.Forms.Button RemovePeople;
        private System.Windows.Forms.Button AddUpdatePeople;
        private System.Windows.Forms.TextBox LanguageList;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox CheckForInterruptedData;
        internal System.Windows.Forms.Button ApiKeyFileButton;
        private System.Windows.Forms.TextBox ApiKeyFile;
        internal System.Windows.Forms.Label label13;
    }
}

