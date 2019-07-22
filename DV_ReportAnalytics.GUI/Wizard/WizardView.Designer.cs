namespace DV_ReportAnalytics.GUI
{
    partial class WizardView
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.linkLabelReset = new System.Windows.Forms.LinkLabel();
            this.linkLabelExport = new System.Windows.Forms.LinkLabel();
            this.linkLabelImport = new System.Windows.Forms.LinkLabel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.panelTypeList = new System.Windows.Forms.Panel();
            this.listBoxTypeList = new System.Windows.Forms.ListBox();
            this.panelProperty = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelDisplays = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogConfig = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.panelNavigation.SuspendLayout();
            this.panelTypeList.SuspendLayout();
            this.panelProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.linkLabelReset);
            this.panelNavigation.Controls.Add(this.linkLabelExport);
            this.panelNavigation.Controls.Add(this.linkLabelImport);
            this.panelNavigation.Controls.Add(this.buttonBrowse);
            this.panelNavigation.Controls.Add(this.buttonCancel);
            this.panelNavigation.Controls.Add(this.buttonFinish);
            this.panelNavigation.Controls.Add(this.labelFilePath);
            this.panelNavigation.Controls.Add(this.textBoxFilePath);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(0, 421);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(609, 62);
            this.panelNavigation.TabIndex = 0;
            // 
            // linkLabelReset
            // 
            this.linkLabelReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelReset.AutoSize = true;
            this.linkLabelReset.Location = new System.Drawing.Point(562, 14);
            this.linkLabelReset.Name = "linkLabelReset";
            this.linkLabelReset.Size = new System.Drawing.Size(35, 13);
            this.linkLabelReset.TabIndex = 7;
            this.linkLabelReset.TabStop = true;
            this.linkLabelReset.Text = "Reset";
            this.linkLabelReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelReset_LinkClicked);
            // 
            // linkLabelExport
            // 
            this.linkLabelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelExport.AutoSize = true;
            this.linkLabelExport.Location = new System.Drawing.Point(519, 14);
            this.linkLabelExport.Name = "linkLabelExport";
            this.linkLabelExport.Size = new System.Drawing.Size(37, 13);
            this.linkLabelExport.TabIndex = 6;
            this.linkLabelExport.TabStop = true;
            this.linkLabelExport.Text = "Export";
            this.linkLabelExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelExport_LinkClicked);
            // 
            // linkLabelImport
            // 
            this.linkLabelImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelImport.AutoSize = true;
            this.linkLabelImport.Location = new System.Drawing.Point(477, 14);
            this.linkLabelImport.Name = "linkLabelImport";
            this.linkLabelImport.Size = new System.Drawing.Size(36, 13);
            this.linkLabelImport.TabIndex = 5;
            this.linkLabelImport.TabStop = true;
            this.linkLabelImport.Text = "Import";
            this.linkLabelImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelImport_LinkClicked);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(311, 33);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(441, 33);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Location = new System.Drawing.Point(522, 33);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 2;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(12, 36);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(79, 16);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = "Report Path";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(103, 35);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(202, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // panelTypeList
            // 
            this.panelTypeList.Controls.Add(this.listBoxTypeList);
            this.panelTypeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTypeList.Location = new System.Drawing.Point(0, 0);
            this.panelTypeList.Name = "panelTypeList";
            this.panelTypeList.Size = new System.Drawing.Size(194, 421);
            this.panelTypeList.TabIndex = 1;
            // 
            // listBoxTypeList
            // 
            this.listBoxTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTypeList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTypeList.FormattingEnabled = true;
            this.listBoxTypeList.ItemHeight = 24;
            this.listBoxTypeList.Items.AddRange(new object[] {
            "EPT Report"});
            this.listBoxTypeList.Location = new System.Drawing.Point(0, 0);
            this.listBoxTypeList.Name = "listBoxTypeList";
            this.listBoxTypeList.Size = new System.Drawing.Size(194, 421);
            this.listBoxTypeList.TabIndex = 0;
            this.listBoxTypeList.SelectedIndexChanged += new System.EventHandler(this.ListBoxTypeList_SelectedIndexChanged);
            // 
            // panelProperty
            // 
            this.panelProperty.Controls.Add(this.panelSettings);
            this.panelProperty.Controls.Add(this.panelDisplays);
            this.panelProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperty.Location = new System.Drawing.Point(194, 0);
            this.panelProperty.Name = "panelProperty";
            this.panelProperty.Size = new System.Drawing.Size(415, 421);
            this.panelProperty.TabIndex = 2;
            // 
            // panelSettings
            // 
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(415, 277);
            this.panelSettings.TabIndex = 0;
            // 
            // panelDisplays
            // 
            this.panelDisplays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDisplays.Location = new System.Drawing.Point(0, 277);
            this.panelDisplays.Name = "panelDisplays";
            this.panelDisplays.Size = new System.Drawing.Size(415, 144);
            this.panelDisplays.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Spreadsheet files|*.xlsx;*.xls";
            // 
            // openFileDialogConfig
            // 
            this.openFileDialogConfig.Filter = "Configuration files|*.xml";
            this.openFileDialogConfig.Title = "Import Configuration";
            // 
            // saveFileDialogConfig
            // 
            this.saveFileDialogConfig.FileName = "Config.xml";
            this.saveFileDialogConfig.Filter = "Configuration files|*.xml";
            this.saveFileDialogConfig.Title = "Export Configuration";
            // 
            // WizardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 483);
            this.Controls.Add(this.panelProperty);
            this.Controls.Add(this.panelTypeList);
            this.Controls.Add(this.panelNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WizardView";
            this.Text = "New Report Wizard";
            this.Load += new System.EventHandler(this.WizardView_Load);
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.panelTypeList.ResumeLayout(false);
            this.panelProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelTypeList;
        private System.Windows.Forms.Panel panelProperty;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.ListBox listBoxTypeList;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelDisplays;
        private System.Windows.Forms.LinkLabel linkLabelReset;
        private System.Windows.Forms.LinkLabel linkLabelExport;
        private System.Windows.Forms.LinkLabel linkLabelImport;
        private System.Windows.Forms.OpenFileDialog openFileDialogConfig;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
    }
}