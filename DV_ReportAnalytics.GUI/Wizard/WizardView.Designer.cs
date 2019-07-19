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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.panelTypeList = new System.Windows.Forms.Panel();
            this.listBoxTypeList = new System.Windows.Forms.ListBox();
            this.panelProperty = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelNavigation.SuspendLayout();
            this.panelTypeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonBrowse);
            this.panelNavigation.Controls.Add(this.buttonCancel);
            this.panelNavigation.Controls.Add(this.buttonFinish);
            this.panelNavigation.Controls.Add(this.labelFilePath);
            this.panelNavigation.Controls.Add(this.textBoxFilePath);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(0, 388);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(741, 43);
            this.panelNavigation.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(573, 14);
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
            this.buttonFinish.Location = new System.Drawing.Point(654, 14);
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
            this.labelFilePath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(12, 17);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(85, 17);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = "Report Path";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(103, 16);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(334, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // panelTypeList
            // 
            this.panelTypeList.Controls.Add(this.listBoxTypeList);
            this.panelTypeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTypeList.Location = new System.Drawing.Point(0, 0);
            this.panelTypeList.Name = "panelTypeList";
            this.panelTypeList.Size = new System.Drawing.Size(518, 388);
            this.panelTypeList.TabIndex = 1;
            // 
            // listBoxTypeList
            // 
            this.listBoxTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTypeList.FormattingEnabled = true;
            this.listBoxTypeList.Items.AddRange(new object[] {
            "EPT Report"});
            this.listBoxTypeList.Location = new System.Drawing.Point(0, 0);
            this.listBoxTypeList.Name = "listBoxTypeList";
            this.listBoxTypeList.Size = new System.Drawing.Size(518, 388);
            this.listBoxTypeList.TabIndex = 0;
            this.listBoxTypeList.SelectedIndexChanged += new System.EventHandler(this.ListBoxTypeList_SelectedIndexChanged);
            // 
            // panelProperty
            // 
            this.panelProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperty.Location = new System.Drawing.Point(518, 0);
            this.panelProperty.Name = "panelProperty";
            this.panelProperty.Size = new System.Drawing.Size(223, 388);
            this.panelProperty.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(443, 14);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Spreadsheet files|*.xlsx;*.xls";
            // 
            // WizardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 431);
            this.Controls.Add(this.panelProperty);
            this.Controls.Add(this.panelTypeList);
            this.Controls.Add(this.panelNavigation);
            this.Name = "WizardView";
            this.Text = "WizardView";
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.panelTypeList.ResumeLayout(false);
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
    }
}