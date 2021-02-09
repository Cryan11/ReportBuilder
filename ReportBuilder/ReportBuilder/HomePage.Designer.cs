namespace ReportBuilder
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonSavedReports = new System.Windows.Forms.Button();
            this.buttonQueryBuilder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.gbQueryBuilder = new System.Windows.Forms.GroupBox();
            this.cbParams = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHistory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.checkedlistbox = new System.Windows.Forms.CheckedListBox();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbQueryBuilder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel.Controls.Add(this.buttonSettings);
            this.panel.Controls.Add(this.buttonImport);
            this.panel.Controls.Add(this.buttonSavedReports);
            this.panel.Controls.Add(this.buttonQueryBuilder);
            this.panel.Controls.Add(this.panelLogo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(220, 609);
            this.panel.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettings.Location = new System.Drawing.Point(0, 532);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(220, 77);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonImport.FlatAppearance.BorderSize = 0;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonImport.Location = new System.Drawing.Point(0, 251);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonImport.Size = new System.Drawing.Size(220, 77);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonSavedReports
            // 
            this.buttonSavedReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSavedReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSavedReports.FlatAppearance.BorderSize = 0;
            this.buttonSavedReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavedReports.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavedReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSavedReports.Location = new System.Drawing.Point(0, 174);
            this.buttonSavedReports.Name = "buttonSavedReports";
            this.buttonSavedReports.Size = new System.Drawing.Size(220, 77);
            this.buttonSavedReports.TabIndex = 2;
            this.buttonSavedReports.Text = "Saved Reports";
            this.buttonSavedReports.UseVisualStyleBackColor = false;
            this.buttonSavedReports.Click += new System.EventHandler(this.buttonSavedReports_Click);
            // 
            // buttonQueryBuilder
            // 
            this.buttonQueryBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonQueryBuilder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQueryBuilder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQueryBuilder.FlatAppearance.BorderSize = 0;
            this.buttonQueryBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQueryBuilder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQueryBuilder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonQueryBuilder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQueryBuilder.Location = new System.Drawing.Point(0, 97);
            this.buttonQueryBuilder.Name = "buttonQueryBuilder";
            this.buttonQueryBuilder.Size = new System.Drawing.Size(220, 77);
            this.buttonQueryBuilder.TabIndex = 1;
            this.buttonQueryBuilder.Text = "Query Builder";
            this.buttonQueryBuilder.UseVisualStyleBackColor = false;
            this.buttonQueryBuilder.Click += new System.EventHandler(this.buttonQueryBuilder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 97);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 50);
            this.panel1.TabIndex = 1;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPage.Location = new System.Drawing.Point(6, 7);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(195, 35);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "PAGE LABEL";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbQueryBuilder
            // 
            this.gbQueryBuilder.Controls.Add(this.checkedlistbox);
            this.gbQueryBuilder.Controls.Add(this.lblColumns);
            this.gbQueryBuilder.Controls.Add(this.button1);
            this.gbQueryBuilder.Controls.Add(this.dgReport);
            this.gbQueryBuilder.Controls.Add(this.cbParams);
            this.gbQueryBuilder.Controls.Add(this.label3);
            this.gbQueryBuilder.Controls.Add(this.cbHistory);
            this.gbQueryBuilder.Controls.Add(this.label2);
            this.gbQueryBuilder.Controls.Add(this.cbTable);
            this.gbQueryBuilder.Controls.Add(this.label1);
            this.gbQueryBuilder.Location = new System.Drawing.Point(223, 53);
            this.gbQueryBuilder.Name = "gbQueryBuilder";
            this.gbQueryBuilder.Size = new System.Drawing.Size(851, 555);
            this.gbQueryBuilder.TabIndex = 2;
            this.gbQueryBuilder.TabStop = false;
            // 
            // cbParams
            // 
            this.cbParams.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbParams.FormattingEnabled = true;
            this.cbParams.Items.AddRange(new object[] {
            "ALL",
            "SPECIFIC"});
            this.cbParams.Location = new System.Drawing.Point(109, 121);
            this.cbParams.Name = "cbParams";
            this.cbParams.Size = new System.Drawing.Size(121, 21);
            this.cbParams.TabIndex = 5;
            this.cbParams.SelectedIndexChanged += new System.EventHandler(this.cbParams_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PARAMS";
            // 
            // cbHistory
            // 
            this.cbHistory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbHistory.FormattingEnabled = true;
            this.cbHistory.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbHistory.Location = new System.Drawing.Point(109, 23);
            this.cbHistory.Name = "cbHistory";
            this.cbHistory.Size = new System.Drawing.Size(121, 21);
            this.cbHistory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HISTORY?";
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Items.AddRange(new object[] {
            "Animal",
            "Checks",
            "Charges",
            "Customer"});
            this.cbTable.Location = new System.Drawing.Point(109, 76);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 21);
            this.cbTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT TABLE:";
            // 
            // dgReport
            // 
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Location = new System.Drawing.Point(204, 194);
            this.dgReport.Name = "dgReport";
            this.dgReport.Size = new System.Drawing.Size(548, 355);
            this.dgReport.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.ForeColor = System.Drawing.Color.LightGray;
            this.lblColumns.Location = new System.Drawing.Point(253, 125);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(63, 13);
            this.lblColumns.TabIndex = 8;
            this.lblColumns.Text = "COLUMNS:";
            this.lblColumns.Visible = false;
            // 
            // checkedlistbox
            // 
            this.checkedlistbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkedlistbox.CheckOnClick = true;
            this.checkedlistbox.FormattingEnabled = true;
            this.checkedlistbox.Location = new System.Drawing.Point(322, 79);
            this.checkedlistbox.Name = "checkedlistbox";
            this.checkedlistbox.Size = new System.Drawing.Size(120, 94);
            this.checkedlistbox.TabIndex = 10;
            this.checkedlistbox.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1075, 609);
            this.Controls.Add(this.gbQueryBuilder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.Text = "Report Builder";
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbQueryBuilder.ResumeLayout(false);
            this.gbQueryBuilder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.GroupBox gbQueryBuilder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTable;
        public System.Windows.Forms.Button buttonSettings;
        public System.Windows.Forms.Button buttonImport;
        public System.Windows.Forms.Button buttonSavedReports;
        public System.Windows.Forms.Button buttonQueryBuilder;
        private System.Windows.Forms.ComboBox cbHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.CheckedListBox checkedlistbox;
    }
}

