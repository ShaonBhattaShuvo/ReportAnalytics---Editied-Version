namespace DV_ReportAnalytics.GUI
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
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTableDisplay = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.contourPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.CanOverflow = false;
            this.toolStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolStripButtonSettings,
            this.toolStripButtonTableDisplay,
            this.toolStripDropDownButton1,
            this.toolStripButtonHelp});
            this.toolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.toolStripMain.Size = new System.Drawing.Size(1045, 33);
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = global::DV_ReportAnalytics.GUI.Properties.Resources.folder_32;
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonOpenFile.Tag = "Open";
            this.toolStripButtonOpenFile.Text = "Open File";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.ToolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveFile
            // 
            this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveFile.Enabled = false;
            this.toolStripButtonSaveFile.Image = global::DV_ReportAnalytics.GUI.Properties.Resources.save_as_32;
            this.toolStripButtonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
            this.toolStripButtonSaveFile.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonSaveFile.Tag = "Save";
            this.toolStripButtonSaveFile.Text = "Save File";
            this.toolStripButtonSaveFile.Click += new System.EventHandler(this.ToolStripButtonSaveFile_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Enabled = false;
            this.toolStripButtonSettings.Image = global::DV_ReportAnalytics.GUI.Properties.Resources.settings_32;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonSettings.Tag = "Settings";
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.ToolStripButtonSettings_Click);
            // 
            // toolStripButtonTableDisplay
            // 
            this.toolStripButtonTableDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTableDisplay.Enabled = false;
            this.toolStripButtonTableDisplay.Image = global::DV_ReportAnalytics.GUI.Properties.Resources.list_32;
            this.toolStripButtonTableDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTableDisplay.Name = "toolStripButtonTableDisplay";
            this.toolStripButtonTableDisplay.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonTableDisplay.Tag = "Table";
            this.toolStripButtonTableDisplay.Text = "Table Display";
            this.toolStripButtonTableDisplay.Click += new System.EventHandler(this.ToolStripButtonTableDisplay_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contourPlotToolStripMenuItem,
            this.dPlotToolStripMenuItem});
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton1.Image = global::DV_ReportAnalytics.GUI.Properties.Resources.area_chart_32;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 28);
            this.toolStripDropDownButton1.Tag = "Graph";
            this.toolStripDropDownButton1.Text = "Toggle Graph Window";
            // 
            // contourPlotToolStripMenuItem
            // 
            this.contourPlotToolStripMenuItem.Name = "contourPlotToolStripMenuItem";
            this.contourPlotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contourPlotToolStripMenuItem.Text = "Contour Map";
            this.contourPlotToolStripMenuItem.Click += new System.EventHandler(this.contourPlotToolStripMenuItem_Click);
            // 
            // dPlotToolStripMenuItem
            // 
            this.dPlotToolStripMenuItem.Name = "dPlotToolStripMenuItem";
            this.dPlotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dPlotToolStripMenuItem.Text = "3D Surface Plot";
            this.dPlotToolStripMenuItem.Click += new System.EventHandler(this.dPlotToolStripMenuItem_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::DV_ReportAnalytics.GUI.Properties.Resources.help_32;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonHelp.Tag = "Help";
            this.toolStripButtonHelp.Text = "Help";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.ToolStripButtonHelp_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 33);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainerMain.Panel2Collapsed = true;
            this.splitContainerMain.Size = new System.Drawing.Size(1045, 657);
            this.splitContainerMain.SplitterDistance = 392;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Untitled Report";
            this.saveFileDialog.Filter = "Spreadsheet files|*.xlsx;*.xls";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DV Report Analytics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem contourPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dPlotToolStripMenuItem;
    }
}

