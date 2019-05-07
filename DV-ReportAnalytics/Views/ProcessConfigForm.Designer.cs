namespace DV_ReportAnalytics.Views
{
    partial class ProcessConfigForm
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
            this.newFileWizardPage21 = new DV_ReportAnalytics.Views.NewFileWizardPage2();
            this.SuspendLayout();
            // 
            // newFileWizardPage21
            // 
            this.newFileWizardPage21.Location = new System.Drawing.Point(12, 12);
            this.newFileWizardPage21.Name = "newFileWizardPage21";
            this.newFileWizardPage21.Size = new System.Drawing.Size(354, 537);
            this.newFileWizardPage21.TabIndex = 0;
            // 
            // ProcessConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 552);
            this.Controls.Add(this.newFileWizardPage21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "ConfigForm";
            this.ResumeLayout(false);

        }

        #endregion

        private NewFileWizardPage2 newFileWizardPage21;
    }
}