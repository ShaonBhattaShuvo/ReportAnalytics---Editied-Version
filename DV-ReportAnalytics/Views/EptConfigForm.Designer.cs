namespace DV_ReportAnalytics.Views
{
    partial class EptConfigForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.tableLayoutPanelInterp = new System.Windows.Forms.TableLayoutPanel();
            this.labelSpeedInterp = new System.Windows.Forms.Label();
            this.labelTorqueInterp = new System.Windows.Forms.Label();
            this.numericUpDownSpeedInterp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTorqueInterp = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelInterp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedInterp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTorqueInterp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(403, 393);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 39);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelInterp
            // 
            this.tableLayoutPanelInterp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelInterp.ColumnCount = 2;
            this.tableLayoutPanelInterp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelInterp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelInterp.Controls.Add(this.labelSpeedInterp, 0, 0);
            this.tableLayoutPanelInterp.Controls.Add(this.labelTorqueInterp, 0, 1);
            this.tableLayoutPanelInterp.Controls.Add(this.numericUpDownSpeedInterp, 1, 0);
            this.tableLayoutPanelInterp.Controls.Add(this.numericUpDownTorqueInterp, 1, 1);
            this.tableLayoutPanelInterp.Location = new System.Drawing.Point(22, 22);
            this.tableLayoutPanelInterp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanelInterp.Name = "tableLayoutPanelInterp";
            this.tableLayoutPanelInterp.RowCount = 2;
            this.tableLayoutPanelInterp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInterp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInterp.Size = new System.Drawing.Size(519, 96);
            this.tableLayoutPanelInterp.TabIndex = 3;
            // 
            // labelSpeedInterp
            // 
            this.labelSpeedInterp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSpeedInterp.AutoSize = true;
            this.labelSpeedInterp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSpeedInterp.Location = new System.Drawing.Point(6, 0);
            this.labelSpeedInterp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSpeedInterp.Name = "labelSpeedInterp";
            this.labelSpeedInterp.Size = new System.Drawing.Size(181, 48);
            this.labelSpeedInterp.TabIndex = 0;
            this.labelSpeedInterp.Text = "Speed Interpolation";
            this.labelSpeedInterp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTorqueInterp
            // 
            this.labelTorqueInterp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTorqueInterp.AutoSize = true;
            this.labelTorqueInterp.Location = new System.Drawing.Point(6, 48);
            this.labelTorqueInterp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTorqueInterp.Name = "labelTorqueInterp";
            this.labelTorqueInterp.Size = new System.Drawing.Size(186, 48);
            this.labelTorqueInterp.TabIndex = 1;
            this.labelTorqueInterp.Text = "Torque Interpolation";
            this.labelTorqueInterp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownSpeedInterp
            // 
            this.numericUpDownSpeedInterp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSpeedInterp.Location = new System.Drawing.Point(421, 6);
            this.numericUpDownSpeedInterp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownSpeedInterp.Name = "numericUpDownSpeedInterp";
            this.numericUpDownSpeedInterp.Size = new System.Drawing.Size(92, 29);
            this.numericUpDownSpeedInterp.TabIndex = 2;
            // 
            // numericUpDownTorqueInterp
            // 
            this.numericUpDownTorqueInterp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTorqueInterp.Location = new System.Drawing.Point(421, 54);
            this.numericUpDownTorqueInterp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownTorqueInterp.Name = "numericUpDownTorqueInterp";
            this.numericUpDownTorqueInterp.Size = new System.Drawing.Size(92, 29);
            this.numericUpDownTorqueInterp.TabIndex = 3;
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(22, 185);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(516, 148);
            this.checkedListBox.TabIndex = 4;
            // 
            // EptConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 454);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.tableLayoutPanelInterp);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EptConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "EptForm";
            this.tableLayoutPanelInterp.ResumeLayout(false);
            this.tableLayoutPanelInterp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedInterp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTorqueInterp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInterp;
        private System.Windows.Forms.Label labelSpeedInterp;
        private System.Windows.Forms.Label labelTorqueInterp;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedInterp;
        private System.Windows.Forms.NumericUpDown numericUpDownTorqueInterp;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}