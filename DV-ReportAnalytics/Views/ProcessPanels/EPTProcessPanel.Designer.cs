namespace DV_ReportAnalytics.Views.ProcessPanels
{
    partial class EPTProcessPanel
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelTextColumn = new System.Windows.Forms.Label();
            this.labelDelimiter = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelValueColumn = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.numericUpDownTextColumn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownValueColumn = new System.Windows.Forms.NumericUpDown();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueColumn)).BeginInit();
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
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelInputSheetName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDelimiter, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelOutputSheetName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxInputSheetName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxOutputSheetName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelType, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTextColumn, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.labelDelimiter, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelText, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelValueColumn, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.textBoxText, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownTextColumn, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownValueColumn, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.textBoxType, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(369, 361);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(4, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(177, 44);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInputSheetName
            // 
            this.labelInputSheetName.AutoSize = true;
            this.labelInputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInputSheetName.Location = new System.Drawing.Point(4, 91);
            this.labelInputSheetName.Name = "labelInputSheetName";
            this.labelInputSheetName.Size = new System.Drawing.Size(177, 44);
            this.labelInputSheetName.TabIndex = 3;
            this.labelInputSheetName.Text = "Input Sheet Name";
            this.labelInputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDelimiter
            // 
            this.textBoxDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDelimiter.Location = new System.Drawing.Point(187, 228);
            this.textBoxDelimiter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDelimiter.Name = "textBoxDelimiter";
            this.textBoxDelimiter.Size = new System.Drawing.Size(179, 20);
            this.textBoxDelimiter.TabIndex = 12;
            // 
            // labelOutputSheetName
            // 
            this.labelOutputSheetName.AutoSize = true;
            this.labelOutputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutputSheetName.Location = new System.Drawing.Point(4, 136);
            this.labelOutputSheetName.Name = "labelOutputSheetName";
            this.labelOutputSheetName.Size = new System.Drawing.Size(177, 44);
            this.labelOutputSheetName.TabIndex = 4;
            this.labelOutputSheetName.Text = "Output Sheet Name";
            this.labelOutputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(188, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "EPT Report Results";
            // 
            // textBoxInputSheetName
            // 
            this.textBoxInputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInputSheetName.Location = new System.Drawing.Point(188, 94);
            this.textBoxInputSheetName.Name = "textBoxInputSheetName";
            this.textBoxInputSheetName.Size = new System.Drawing.Size(177, 20);
            this.textBoxInputSheetName.TabIndex = 8;
            this.textBoxInputSheetName.Text = "Results";
            // 
            // textBoxOutputSheetName
            // 
            this.textBoxOutputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutputSheetName.Location = new System.Drawing.Point(188, 139);
            this.textBoxOutputSheetName.Name = "textBoxOutputSheetName";
            this.textBoxOutputSheetName.Size = new System.Drawing.Size(177, 20);
            this.textBoxOutputSheetName.TabIndex = 9;
            this.textBoxOutputSheetName.Text = "Combined Results";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(4, 1);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(177, 44);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTextColumn
            // 
            this.labelTextColumn.AutoSize = true;
            this.labelTextColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTextColumn.Location = new System.Drawing.Point(3, 271);
            this.labelTextColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextColumn.Name = "labelTextColumn";
            this.labelTextColumn.Size = new System.Drawing.Size(179, 44);
            this.labelTextColumn.TabIndex = 12;
            this.labelTextColumn.Text = "Text Column";
            this.labelTextColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDelimiter
            // 
            this.labelDelimiter.AutoSize = true;
            this.labelDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDelimiter.Location = new System.Drawing.Point(3, 226);
            this.labelDelimiter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDelimiter.Name = "labelDelimiter";
            this.labelDelimiter.Size = new System.Drawing.Size(179, 44);
            this.labelDelimiter.TabIndex = 14;
            this.labelDelimiter.Text = "Delimiter";
            this.labelDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Location = new System.Drawing.Point(3, 181);
            this.labelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(179, 44);
            this.labelText.TabIndex = 15;
            this.labelText.Text = "Text";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValueColumn
            // 
            this.labelValueColumn.AutoSize = true;
            this.labelValueColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValueColumn.Location = new System.Drawing.Point(3, 316);
            this.labelValueColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueColumn.Name = "labelValueColumn";
            this.labelValueColumn.Size = new System.Drawing.Size(179, 44);
            this.labelValueColumn.TabIndex = 13;
            this.labelValueColumn.Text = "Value Column";
            this.labelValueColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxText
            // 
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Location = new System.Drawing.Point(187, 183);
            this.textBoxText.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(179, 20);
            this.textBoxText.TabIndex = 18;
            // 
            // numericUpDownTextColumn
            // 
            this.numericUpDownTextColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownTextColumn.Location = new System.Drawing.Point(187, 273);
            this.numericUpDownTextColumn.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTextColumn.Name = "numericUpDownTextColumn";
            this.numericUpDownTextColumn.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownTextColumn.TabIndex = 16;
            // 
            // numericUpDownValueColumn
            // 
            this.numericUpDownValueColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownValueColumn.Location = new System.Drawing.Point(188, 319);
            this.numericUpDownValueColumn.Name = "numericUpDownValueColumn";
            this.numericUpDownValueColumn.Size = new System.Drawing.Size(177, 20);
            this.numericUpDownValueColumn.TabIndex = 19;
            // 
            // textBoxType
            // 
            this.textBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxType.Location = new System.Drawing.Point(188, 4);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(177, 20);
            this.textBoxType.TabIndex = 20;
            // 
            // EPTProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelGeneral);
            this.Name = "EPTProcess";
            this.Size = new System.Drawing.Size(369, 374);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueColumn)).EndInit();
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
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Label labelTextColumn;
        private System.Windows.Forms.Label labelDelimiter;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelValueColumn;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.NumericUpDown numericUpDownTextColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownValueColumn;
        private System.Windows.Forms.TextBox textBoxType;
    }
}
