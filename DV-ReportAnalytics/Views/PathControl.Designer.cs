namespace DV_ReportAnalytics.Views
{
    partial class PathControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileBrowserWithLabelResult = new DV_ReportAnalytics.Views.Components.FileBrowserWithLabel();
            this.fileBrowserWithLabelConfig = new DV_ReportAnalytics.Views.Components.FileBrowserWithLabel();
            this.SuspendLayout();
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
            // fileBrowserWithLabelResult
            // 
            this.fileBrowserWithLabelResult.Description = "Result file path";
            this.fileBrowserWithLabelResult.Filter = "Worksheets|*.xls;*.xlsx;*.xlsm;*.xlsb";
            this.fileBrowserWithLabelResult.Location = new System.Drawing.Point(8, 95);
            this.fileBrowserWithLabelResult.Name = "fileBrowserWithLabelResult";
            this.fileBrowserWithLabelResult.Size = new System.Drawing.Size(320, 43);
            this.fileBrowserWithLabelResult.TabIndex = 4;
            // 
            // fileBrowserWithLabelConfig
            // 
            this.fileBrowserWithLabelConfig.Description = "Configuration file path";
            this.fileBrowserWithLabelConfig.Filter = "Configuration Files|*.xml";
            this.fileBrowserWithLabelConfig.Location = new System.Drawing.Point(8, 144);
            this.fileBrowserWithLabelConfig.Name = "fileBrowserWithLabelConfig";
            this.fileBrowserWithLabelConfig.Size = new System.Drawing.Size(320, 43);
            this.fileBrowserWithLabelConfig.TabIndex = 5;
            // 
            // NewFileWizardPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileBrowserWithLabelConfig);
            this.Controls.Add(this.fileBrowserWithLabelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewFileWizardPage1";
            this.Size = new System.Drawing.Size(539, 213);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.FileBrowserWithLabel fileBrowserWithLabelResult;
        private Components.FileBrowserWithLabel fileBrowserWithLabelConfig;
    }
}
