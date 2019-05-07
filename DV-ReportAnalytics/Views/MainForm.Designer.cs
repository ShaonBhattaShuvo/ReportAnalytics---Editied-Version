﻿namespace DV_ReportAnalytics.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTableDisplay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGraphToggle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.workbookView = new SpreadsheetGear.Windows.Forms.WorkbookView();
            this.graphContainer = new System.Windows.Forms.WebBrowser();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolStripButtonSettings,
            this.toolStripButtonTableDisplay,
            this.toolStripButtonGraphToggle,
            this.toolStripButtonHelp});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1212, 35);
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = global::DV_ReportAnalytics.Properties.Resources.folder_32;
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonOpenFile.Tag = "Open";
            this.toolStripButtonOpenFile.Text = "Open File";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveFile
            // 
            this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveFile.Enabled = false;
            this.toolStripButtonSaveFile.Image = global::DV_ReportAnalytics.Properties.Resources.save_as_32;
            this.toolStripButtonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
            this.toolStripButtonSaveFile.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonSaveFile.Tag = "Save";
            this.toolStripButtonSaveFile.Text = "Save File";
            this.toolStripButtonSaveFile.Click += new System.EventHandler(this.toolStripButtonSaveFile_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Enabled = false;
            this.toolStripButtonSettings.Image = global::DV_ReportAnalytics.Properties.Resources.settings_32;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonSettings.Tag = "Settings";
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonTableDisplay
            // 
            this.toolStripButtonTableDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTableDisplay.Enabled = false;
            this.toolStripButtonTableDisplay.Image = global::DV_ReportAnalytics.Properties.Resources.list_32;
            this.toolStripButtonTableDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTableDisplay.Name = "toolStripButtonTableDisplay";
            this.toolStripButtonTableDisplay.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonTableDisplay.Tag = "Table";
            this.toolStripButtonTableDisplay.Text = "Table Display";
            this.toolStripButtonTableDisplay.Click += new System.EventHandler(this.toolStripButtonTableDisplay_Click);
            // 
            // toolStripButtonGraphToggle
            // 
            this.toolStripButtonGraphToggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphToggle.Enabled = false;
            this.toolStripButtonGraphToggle.Image = global::DV_ReportAnalytics.Properties.Resources.area_chart_32;
            this.toolStripButtonGraphToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphToggle.Name = "toolStripButtonGraphToggle";
            this.toolStripButtonGraphToggle.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonGraphToggle.Tag = "Graph";
            this.toolStripButtonGraphToggle.Text = "Toggle Graph Window";
            this.toolStripButtonGraphToggle.Click += new System.EventHandler(this.toolStripButtonGraphToggle_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::DV_ReportAnalytics.Properties.Resources.help_32;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonHelp.Tag = "Help";
            this.toolStripButtonHelp.Text = "Help";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 35);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.workbookView);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainerMain.Panel2.Controls.Add(this.graphContainer);
            this.splitContainerMain.Panel2Collapsed = true;
            this.splitContainerMain.Size = new System.Drawing.Size(1212, 540);
            this.splitContainerMain.SplitterDistance = 1107;
            this.splitContainerMain.TabIndex = 1;
            // 
            // workbookView
            // 
            this.workbookView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workbookView.FormulaBar = null;
            this.workbookView.Location = new System.Drawing.Point(3, 3);
            this.workbookView.Name = "workbookView";
            this.workbookView.Size = new System.Drawing.Size(1206, 534);
            this.workbookView.TabIndex = 0;
            this.workbookView.Visible = false;
            this.workbookView.WorkbookSetState = resources.GetString("workbookView.WorkbookSetState");
            // 
            // graphContainer
            // 
            this.graphContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphContainer.Location = new System.Drawing.Point(0, 0);
            this.graphContainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.graphContainer.Name = "graphContainer";
            this.graphContainer.Size = new System.Drawing.Size(96, 100);
            this.graphContainer.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Worksheets|*.xls;*.xlsx;*.xlsm;*.xlsb";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Worksheets|*.xls;*.xlsx;*.xlsm;*.xlsb";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1137, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 575);
            this.Controls.Add(this.button1);
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
            this.splitContainerMain.Panel2.ResumeLayout(false);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.WebBrowser graphContainer;
        private SpreadsheetGear.Windows.Forms.WorkbookView workbookView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button1;
    }
}

