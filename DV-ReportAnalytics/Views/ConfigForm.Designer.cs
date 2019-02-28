namespace DV_ReportAnalytics.Views
{
    partial class ConfigForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelParameter = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInputSheetName = new System.Windows.Forms.Label();
            this.labelOutputSheetName = new System.Windows.Forms.Label();
            this.labelResultFormat = new System.Windows.Forms.Label();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInputSheetName = new System.Windows.Forms.TextBox();
            this.textBoxOutputSheetName = new System.Windows.Forms.TextBox();
            this.textBoxResultFormat = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelParameter, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelInputSheetName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelOutputSheetName, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelResultFormat, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxInputSheetName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxOutputSheetName, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxResultFormat, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxParameter, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.comboBoxType, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(390, 234);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelParameter
            // 
            this.labelParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelParameter.AutoSize = true;
            this.labelParameter.Location = new System.Drawing.Point(4, 1);
            this.labelParameter.Name = "labelParameter";
            this.labelParameter.Size = new System.Drawing.Size(55, 37);
            this.labelParameter.TabIndex = 0;
            this.labelParameter.Text = "Parameter";
            this.labelParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(4, 39);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 37);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 37);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInputSheetName
            // 
            this.labelInputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInputSheetName.AutoSize = true;
            this.labelInputSheetName.Location = new System.Drawing.Point(4, 115);
            this.labelInputSheetName.Name = "labelInputSheetName";
            this.labelInputSheetName.Size = new System.Drawing.Size(93, 37);
            this.labelInputSheetName.TabIndex = 3;
            this.labelInputSheetName.Text = "Input Sheet Name";
            this.labelInputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOutputSheetName
            // 
            this.labelOutputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutputSheetName.AutoSize = true;
            this.labelOutputSheetName.Location = new System.Drawing.Point(4, 153);
            this.labelOutputSheetName.Name = "labelOutputSheetName";
            this.labelOutputSheetName.Size = new System.Drawing.Size(101, 37);
            this.labelOutputSheetName.TabIndex = 4;
            this.labelOutputSheetName.Text = "Output Sheet Name";
            this.labelOutputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResultFormat
            // 
            this.labelResultFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultFormat.AutoSize = true;
            this.labelResultFormat.Location = new System.Drawing.Point(4, 191);
            this.labelResultFormat.Name = "labelResultFormat";
            this.labelResultFormat.Size = new System.Drawing.Size(72, 42);
            this.labelResultFormat.TabIndex = 5;
            this.labelResultFormat.Text = "Result Format";
            this.labelResultFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParameter.Location = new System.Drawing.Point(198, 4);
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(188, 20);
            this.textBoxParameter.TabIndex = 6;
            this.textBoxParameter.Text = "Value";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(198, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "EPT Report Results";
            // 
            // textBoxInputSheetName
            // 
            this.textBoxInputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputSheetName.Location = new System.Drawing.Point(198, 118);
            this.textBoxInputSheetName.Name = "textBoxInputSheetName";
            this.textBoxInputSheetName.Size = new System.Drawing.Size(188, 20);
            this.textBoxInputSheetName.TabIndex = 8;
            this.textBoxInputSheetName.Text = "Results";
            // 
            // textBoxOutputSheetName
            // 
            this.textBoxOutputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputSheetName.Location = new System.Drawing.Point(198, 156);
            this.textBoxOutputSheetName.Name = "textBoxOutputSheetName";
            this.textBoxOutputSheetName.Size = new System.Drawing.Size(188, 20);
            this.textBoxOutputSheetName.TabIndex = 9;
            this.textBoxOutputSheetName.Text = "Combined Results";
            // 
            // textBoxResultFormat
            // 
            this.textBoxResultFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultFormat.Location = new System.Drawing.Point(198, 194);
            this.textBoxResultFormat.Name = "textBoxResultFormat";
            this.textBoxResultFormat.Size = new System.Drawing.Size(188, 20);
            this.textBoxResultFormat.TabIndex = 10;
            this.textBoxResultFormat.Text = "Speed, Torque";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "EptReport"});
            this.comboBoxType.Location = new System.Drawing.Point(198, 42);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(188, 21);
            this.comboBoxType.TabIndex = 11;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 258);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "ConfigForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelParameter;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInputSheetName;
        private System.Windows.Forms.Label labelOutputSheetName;
        private System.Windows.Forms.Label labelResultFormat;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInputSheetName;
        private System.Windows.Forms.TextBox textBoxOutputSheetName;
        private System.Windows.Forms.TextBox textBoxResultFormat;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}