﻿namespace DV_ReportAnalytics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTableDisplay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGraphToggle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.spreadSheetContainer = new System.Windows.Forms.WebBrowser();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolStripButtonTableDisplay,
            this.toolStripButtonGraphToggle,
            this.toolStripButtonSettings,
            this.toolStripButtonHelp});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1212, 25);
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = global::DV_ReportAnalytics.Properties.Resources.folder_32;
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenFile.Tag = "Open";
            this.toolStripButtonOpenFile.Text = "toolStripButton1";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveFile
            // 
            this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveFile.Image = global::DV_ReportAnalytics.Properties.Resources.save_as_32;
            this.toolStripButtonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
            this.toolStripButtonSaveFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveFile.Tag = "Save";
            this.toolStripButtonSaveFile.Text = "toolStripButton2";
            this.toolStripButtonSaveFile.Click += new System.EventHandler(this.toolStripButtonSaveFile_Click);
            // 
            // toolStripButtonTableDisplay
            // 
            this.toolStripButtonTableDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTableDisplay.Image = global::DV_ReportAnalytics.Properties.Resources.list_32;
            this.toolStripButtonTableDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTableDisplay.Name = "toolStripButtonTableDisplay";
            this.toolStripButtonTableDisplay.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTableDisplay.Tag = "Table";
            this.toolStripButtonTableDisplay.Text = "toolStripButton3";
            this.toolStripButtonTableDisplay.Click += new System.EventHandler(this.toolStripButtonTableDisplay_Click);
            // 
            // toolStripButtonGraphToggle
            // 
            this.toolStripButtonGraphToggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphToggle.Image = global::DV_ReportAnalytics.Properties.Resources.area_chart_32;
            this.toolStripButtonGraphToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphToggle.Name = "toolStripButtonGraphToggle";
            this.toolStripButtonGraphToggle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGraphToggle.Tag = "Graph";
            this.toolStripButtonGraphToggle.Text = "toolStripButton4";
            this.toolStripButtonGraphToggle.Click += new System.EventHandler(this.toolStripButtonGraphToggle_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = global::DV_ReportAnalytics.Properties.Resources.settings_32;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSettings.Tag = "Settings";
            this.toolStripButtonSettings.Text = "toolStripButton5";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::DV_ReportAnalytics.Properties.Resources.help_32;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHelp.Tag = "Help";
            this.toolStripButtonHelp.Text = "toolStripButton1";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.spreadSheetContainer);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainerMain.Size = new System.Drawing.Size(1212, 754);
            this.splitContainerMain.SplitterDistance = 603;
            this.splitContainerMain.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.spreadSheetContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadSheetContainer.Location = new System.Drawing.Point(0, 0);
            this.spreadSheetContainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.spreadSheetContainer.Name = "spreadSheetContainer";
            this.spreadSheetContainer.Size = new System.Drawing.Size(603, 754);
            this.spreadSheetContainer.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 779);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DV Report Analytics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonTableDisplay;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphToggle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.WebBrowser spreadSheetContainer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
