namespace DV_ReportAnalytics.GUI
{
    partial class EPTSettingsView
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInputSheetName = new System.Windows.Forms.Label();
            this.textBoxDelimiter = new System.Windows.Forms.TextBox();
            this.labelOutputSheetName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInputSheetName = new System.Windows.Forms.TextBox();
            this.textBoxOutputSheetName = new System.Windows.Forms.TextBox();
            this.labelParameterColumn = new System.Windows.Forms.Label();
            this.labelDelimiter = new System.Windows.Forms.Label();
            this.labelParameter = new System.Windows.Forms.Label();
            this.labelValueColumn = new System.Windows.Forms.Label();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.textBoxParameterColumn = new System.Windows.Forms.TextBox();
            this.textBoxValueColumn = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGeneral.Location = new System.Drawing.Point(0, 0);
            this.labelGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(169, 13);
            this.labelGeneral.TabIndex = 4;
            this.labelGeneral.Text = "EPT Report Process Configuration";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelInputSheetName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxDelimiter, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelOutputSheetName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxInputSheetName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxOutputSheetName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelParameterColumn, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelDelimiter, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelParameter, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelValueColumn, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.textBoxParameter, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxParameterColumn, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxValueColumn, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(369, 361);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(4, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(177, 50);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInputSheetName
            // 
            this.labelInputSheetName.AutoSize = true;
            this.labelInputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInputSheetName.Location = new System.Drawing.Point(4, 52);
            this.labelInputSheetName.Name = "labelInputSheetName";
            this.labelInputSheetName.Size = new System.Drawing.Size(177, 50);
            this.labelInputSheetName.TabIndex = 3;
            this.labelInputSheetName.Text = "Input Sheet Name";
            this.labelInputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDelimiter
            // 
            this.textBoxDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDelimiter.Location = new System.Drawing.Point(187, 207);
            this.textBoxDelimiter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDelimiter.Name = "textBoxDelimiter";
            this.textBoxDelimiter.Size = new System.Drawing.Size(179, 20);
            this.textBoxDelimiter.TabIndex = 12;
            // 
            // labelOutputSheetName
            // 
            this.labelOutputSheetName.AutoSize = true;
            this.labelOutputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutputSheetName.Location = new System.Drawing.Point(4, 103);
            this.labelOutputSheetName.Name = "labelOutputSheetName";
            this.labelOutputSheetName.Size = new System.Drawing.Size(177, 50);
            this.labelOutputSheetName.TabIndex = 4;
            this.labelOutputSheetName.Text = "Output Sheet Name";
            this.labelOutputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(188, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "EPT Report Results";
            // 
            // textBoxInputSheetName
            // 
            this.textBoxInputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInputSheetName.Location = new System.Drawing.Point(188, 55);
            this.textBoxInputSheetName.Name = "textBoxInputSheetName";
            this.textBoxInputSheetName.Size = new System.Drawing.Size(177, 20);
            this.textBoxInputSheetName.TabIndex = 8;
            this.textBoxInputSheetName.Text = "Results";
            // 
            // textBoxOutputSheetName
            // 
            this.textBoxOutputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutputSheetName.Location = new System.Drawing.Point(188, 106);
            this.textBoxOutputSheetName.Name = "textBoxOutputSheetName";
            this.textBoxOutputSheetName.Size = new System.Drawing.Size(177, 20);
            this.textBoxOutputSheetName.TabIndex = 9;
            this.textBoxOutputSheetName.Text = "Combined Results";
            // 
            // labelParameterColumn
            // 
            this.labelParameterColumn.AutoSize = true;
            this.labelParameterColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParameterColumn.Location = new System.Drawing.Point(3, 256);
            this.labelParameterColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParameterColumn.Name = "labelParameterColumn";
            this.labelParameterColumn.Size = new System.Drawing.Size(179, 50);
            this.labelParameterColumn.TabIndex = 12;
            this.labelParameterColumn.Text = "Parameter Column\r\n(Supports letter or zero based index)";
            this.labelParameterColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDelimiter
            // 
            this.labelDelimiter.AutoSize = true;
            this.labelDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDelimiter.Location = new System.Drawing.Point(3, 205);
            this.labelDelimiter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDelimiter.Name = "labelDelimiter";
            this.labelDelimiter.Size = new System.Drawing.Size(179, 50);
            this.labelDelimiter.TabIndex = 14;
            this.labelDelimiter.Text = "Delimiter";
            this.labelDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelParameter
            // 
            this.labelParameter.AutoSize = true;
            this.labelParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParameter.Location = new System.Drawing.Point(3, 154);
            this.labelParameter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParameter.Name = "labelParameter";
            this.labelParameter.Size = new System.Drawing.Size(179, 50);
            this.labelParameter.TabIndex = 15;
            this.labelParameter.Text = "Parameter";
            this.labelParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValueColumn
            // 
            this.labelValueColumn.AutoSize = true;
            this.labelValueColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValueColumn.Location = new System.Drawing.Point(3, 307);
            this.labelValueColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueColumn.Name = "labelValueColumn";
            this.labelValueColumn.Size = new System.Drawing.Size(179, 53);
            this.labelValueColumn.TabIndex = 13;
            this.labelValueColumn.Text = "Value Column\r\n(Supports letter or zero based index)";
            this.labelValueColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParameter.Location = new System.Drawing.Point(187, 156);
            this.textBoxParameter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(179, 20);
            this.textBoxParameter.TabIndex = 18;
            // 
            // textBoxParameterColumn
            // 
            this.textBoxParameterColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParameterColumn.Location = new System.Drawing.Point(188, 259);
            this.textBoxParameterColumn.Name = "textBoxParameterColumn";
            this.textBoxParameterColumn.Size = new System.Drawing.Size(177, 20);
            this.textBoxParameterColumn.TabIndex = 21;
            // 
            // textBoxValueColumn
            // 
            this.textBoxValueColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValueColumn.Location = new System.Drawing.Point(188, 310);
            this.textBoxValueColumn.Name = "textBoxValueColumn";
            this.textBoxValueColumn.Size = new System.Drawing.Size(177, 20);
            this.textBoxValueColumn.TabIndex = 22;
            // 
            // EPTSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelGeneral);
            this.Name = "EPTSettingsView";
            this.Size = new System.Drawing.Size(369, 374);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInputSheetName;
        private System.Windows.Forms.Label labelOutputSheetName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInputSheetName;
        private System.Windows.Forms.TextBox textBoxOutputSheetName;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Label labelParameterColumn;
        private System.Windows.Forms.Label labelDelimiter;
        private System.Windows.Forms.Label labelParameter;
        private System.Windows.Forms.Label labelValueColumn;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.TextBox textBoxParameterColumn;
        private System.Windows.Forms.TextBox textBoxValueColumn;
    }
}
