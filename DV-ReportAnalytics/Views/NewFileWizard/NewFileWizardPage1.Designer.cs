﻿namespace DV_ReportAnalytics.Views
{
    partial class NewFileWizardPage1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileBrowserWithLabel2 = new DV_ReportAnalytics.Views.FileBrowserWithLabel();
            this.fileBrowserWithLabel1 = new DV_ReportAnalytics.Views.FileBrowserWithLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileBrowserWithLabel2
            // 
            this.fileBrowserWithLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowserWithLabel2.Description = "Configuration file path";
            this.fileBrowserWithLabel2.Filter = "";
            this.fileBrowserWithLabel2.Location = new System.Drawing.Point(3, 144);
            this.fileBrowserWithLabel2.Name = "fileBrowserWithLabel2";
            this.fileBrowserWithLabel2.Size = new System.Drawing.Size(642, 43);
            this.fileBrowserWithLabel2.TabIndex = 1;
            // 
            // fileBrowserWithLabel1
            // 
            this.fileBrowserWithLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowserWithLabel1.Description = "Report file path";
            this.fileBrowserWithLabel1.Filter = "";
            this.fileBrowserWithLabel1.Location = new System.Drawing.Point(3, 95);
            this.fileBrowserWithLabel1.Name = "fileBrowserWithLabel1";
            this.fileBrowserWithLabel1.Size = new System.Drawing.Size(642, 43);
            this.fileBrowserWithLabel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select files and proceed. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Or click \"Finish\" to continue with default configurations.";
            // 
            // NewFileWizardPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileBrowserWithLabel2);
            this.Controls.Add(this.fileBrowserWithLabel1);
            this.Name = "NewFileWizardPage1";
            this.Size = new System.Drawing.Size(648, 278);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileBrowserWithLabel fileBrowserWithLabel1;
        private FileBrowserWithLabel fileBrowserWithLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
