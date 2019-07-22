namespace DV_ReportAnalytics.GUI
{
    partial class EPTDisplaysView
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
            this.labelGeneral = new System.Windows.Forms.Label();
            this.labelRowInterpolation = new System.Windows.Forms.Label();
            this.labelColumnInterpolation = new System.Windows.Forms.Label();
            this.labelMaximumItemsPerRow = new System.Windows.Forms.Label();
            this.textBoxRowInterpolation = new System.Windows.Forms.TextBox();
            this.textBoxColumnInterpolation = new System.Windows.Forms.TextBox();
            this.textBoxMaximumItemsPerRow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneral.Location = new System.Drawing.Point(10, 10);
            this.labelGeneral.Margin = new System.Windows.Forms.Padding(10);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(232, 20);
            this.labelGeneral.TabIndex = 4;
            this.labelGeneral.Text = "EPT Report Display Options";
            // 
            // labelRowInterpolation
            // 
            this.labelRowInterpolation.AutoSize = true;
            this.labelRowInterpolation.Location = new System.Drawing.Point(10, 50);
            this.labelRowInterpolation.Margin = new System.Windows.Forms.Padding(10);
            this.labelRowInterpolation.Name = "labelRowInterpolation";
            this.labelRowInterpolation.Size = new System.Drawing.Size(90, 13);
            this.labelRowInterpolation.TabIndex = 2;
            this.labelRowInterpolation.Text = "Row Interpolation";
            this.labelRowInterpolation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelColumnInterpolation
            // 
            this.labelColumnInterpolation.AutoSize = true;
            this.labelColumnInterpolation.Location = new System.Drawing.Point(10, 83);
            this.labelColumnInterpolation.Margin = new System.Windows.Forms.Padding(10);
            this.labelColumnInterpolation.Name = "labelColumnInterpolation";
            this.labelColumnInterpolation.Size = new System.Drawing.Size(103, 13);
            this.labelColumnInterpolation.TabIndex = 3;
            this.labelColumnInterpolation.Text = "Column Interpolation";
            this.labelColumnInterpolation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaximumItemsPerRow
            // 
            this.labelMaximumItemsPerRow.AutoSize = true;
            this.labelMaximumItemsPerRow.Location = new System.Drawing.Point(10, 116);
            this.labelMaximumItemsPerRow.Margin = new System.Windows.Forms.Padding(10);
            this.labelMaximumItemsPerRow.Name = "labelMaximumItemsPerRow";
            this.labelMaximumItemsPerRow.Size = new System.Drawing.Size(123, 13);
            this.labelMaximumItemsPerRow.TabIndex = 4;
            this.labelMaximumItemsPerRow.Text = "Maximum Items Per Row";
            this.labelMaximumItemsPerRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRowInterpolation
            // 
            this.textBoxRowInterpolation.Location = new System.Drawing.Point(182, 47);
            this.textBoxRowInterpolation.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxRowInterpolation.Name = "textBoxRowInterpolation";
            this.textBoxRowInterpolation.Size = new System.Drawing.Size(150, 20);
            this.textBoxRowInterpolation.TabIndex = 7;
            // 
            // textBoxColumnInterpolation
            // 
            this.textBoxColumnInterpolation.Location = new System.Drawing.Point(182, 80);
            this.textBoxColumnInterpolation.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxColumnInterpolation.Name = "textBoxColumnInterpolation";
            this.textBoxColumnInterpolation.Size = new System.Drawing.Size(150, 20);
            this.textBoxColumnInterpolation.TabIndex = 8;
            // 
            // textBoxMaximumItemsPerRow
            // 
            this.textBoxMaximumItemsPerRow.Location = new System.Drawing.Point(182, 113);
            this.textBoxMaximumItemsPerRow.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxMaximumItemsPerRow.Name = "textBoxMaximumItemsPerRow";
            this.textBoxMaximumItemsPerRow.Size = new System.Drawing.Size(150, 20);
            this.textBoxMaximumItemsPerRow.TabIndex = 9;
            // 
            // EPTDisplaysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.labelColumnInterpolation);
            this.Controls.Add(this.textBoxMaximumItemsPerRow);
            this.Controls.Add(this.labelMaximumItemsPerRow);
            this.Controls.Add(this.textBoxColumnInterpolation);
            this.Controls.Add(this.labelGeneral);
            this.Controls.Add(this.labelRowInterpolation);
            this.Controls.Add(this.textBoxRowInterpolation);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "EPTDisplaysView";
            this.Size = new System.Drawing.Size(344, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.Label labelRowInterpolation;
        private System.Windows.Forms.Label labelColumnInterpolation;
        private System.Windows.Forms.Label labelMaximumItemsPerRow;
        private System.Windows.Forms.TextBox textBoxRowInterpolation;
        private System.Windows.Forms.TextBox textBoxColumnInterpolation;
        private System.Windows.Forms.TextBox textBoxMaximumItemsPerRow;
    }
}
