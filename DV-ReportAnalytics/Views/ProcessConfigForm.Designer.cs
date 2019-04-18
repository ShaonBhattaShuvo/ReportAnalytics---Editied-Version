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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInputSheetName = new System.Windows.Forms.Label();
            this.labelOutputSheetName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInputSheetName = new System.Windows.Forms.TextBox();
            this.textBoxOutputSheetName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEptRow = new System.Windows.Forms.Label();
            this.labelEptCol = new System.Windows.Forms.Label();
            this.labelEptTextIndex = new System.Windows.Forms.Label();
            this.labelEptValueIndex = new System.Windows.Forms.Label();
            this.labelEptDelimiter = new System.Windows.Forms.Label();
            this.textEptBoxRow = new System.Windows.Forms.TextBox();
            this.textEptBoxCol = new System.Windows.Forms.TextBox();
            this.textBoxEptDelimiter = new System.Windows.Forms.TextBox();
            this.numericUpDownEptTextIndex = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEptValueIndex = new System.Windows.Forms.NumericUpDown();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.labelEptFormat = new System.Windows.Forms.Label();
            this.panelEPT = new System.Windows.Forms.Panel();
            this.labelEptPreview = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEptTextIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEptValueIndex)).BeginInit();
            this.panelEPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelInputSheetName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelOutputSheetName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxInputSheetName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxOutputSheetName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelType, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.comboBoxType, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(326, 200);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 48);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInputSheetName
            // 
            this.labelInputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInputSheetName.AutoSize = true;
            this.labelInputSheetName.Location = new System.Drawing.Point(4, 99);
            this.labelInputSheetName.Name = "labelInputSheetName";
            this.labelInputSheetName.Size = new System.Drawing.Size(93, 48);
            this.labelInputSheetName.TabIndex = 3;
            this.labelInputSheetName.Text = "Input Sheet Name";
            this.labelInputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOutputSheetName
            // 
            this.labelOutputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutputSheetName.AutoSize = true;
            this.labelOutputSheetName.Location = new System.Drawing.Point(4, 148);
            this.labelOutputSheetName.Name = "labelOutputSheetName";
            this.labelOutputSheetName.Size = new System.Drawing.Size(101, 51);
            this.labelOutputSheetName.TabIndex = 4;
            this.labelOutputSheetName.Text = "Output Sheet Name";
            this.labelOutputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(166, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "EPT Report Results";
            // 
            // textBoxInputSheetName
            // 
            this.textBoxInputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputSheetName.Location = new System.Drawing.Point(166, 102);
            this.textBoxInputSheetName.Name = "textBoxInputSheetName";
            this.textBoxInputSheetName.Size = new System.Drawing.Size(156, 20);
            this.textBoxInputSheetName.TabIndex = 8;
            this.textBoxInputSheetName.Text = "Results";
            // 
            // textBoxOutputSheetName
            // 
            this.textBoxOutputSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputSheetName.Location = new System.Drawing.Point(166, 151);
            this.textBoxOutputSheetName.Name = "textBoxOutputSheetName";
            this.textBoxOutputSheetName.Size = new System.Drawing.Size(156, 20);
            this.textBoxOutputSheetName.TabIndex = 9;
            this.textBoxOutputSheetName.Text = "Combined Results";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(4, 1);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 48);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "EptReport"});
            this.comboBoxType.Location = new System.Drawing.Point(166, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(156, 21);
            this.comboBoxType.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelEptRow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEptCol, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEptTextIndex, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEptValueIndex, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEptDelimiter, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textEptBoxRow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textEptBoxCol, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEptDelimiter, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownEptTextIndex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownEptValueIndex, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 163);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelEptRow
            // 
            this.labelEptRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEptRow.AutoSize = true;
            this.labelEptRow.Location = new System.Drawing.Point(2, 0);
            this.labelEptRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptRow.Name = "labelEptRow";
            this.labelEptRow.Size = new System.Drawing.Size(58, 32);
            this.labelEptRow.TabIndex = 0;
            this.labelEptRow.Text = "Row Label";
            // 
            // labelEptCol
            // 
            this.labelEptCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEptCol.AutoSize = true;
            this.labelEptCol.Location = new System.Drawing.Point(2, 32);
            this.labelEptCol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptCol.Name = "labelEptCol";
            this.labelEptCol.Size = new System.Drawing.Size(71, 32);
            this.labelEptCol.TabIndex = 1;
            this.labelEptCol.Text = "Column Label";
            // 
            // labelEptTextIndex
            // 
            this.labelEptTextIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEptTextIndex.AutoSize = true;
            this.labelEptTextIndex.Location = new System.Drawing.Point(2, 64);
            this.labelEptTextIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptTextIndex.Name = "labelEptTextIndex";
            this.labelEptTextIndex.Size = new System.Drawing.Size(57, 32);
            this.labelEptTextIndex.TabIndex = 3;
            this.labelEptTextIndex.Text = "Text Index";
            // 
            // labelEptValueIndex
            // 
            this.labelEptValueIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEptValueIndex.AutoSize = true;
            this.labelEptValueIndex.Location = new System.Drawing.Point(2, 96);
            this.labelEptValueIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptValueIndex.Name = "labelEptValueIndex";
            this.labelEptValueIndex.Size = new System.Drawing.Size(63, 32);
            this.labelEptValueIndex.TabIndex = 4;
            this.labelEptValueIndex.Text = "Value Index";
            // 
            // labelEptDelimiter
            // 
            this.labelEptDelimiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEptDelimiter.AutoSize = true;
            this.labelEptDelimiter.Location = new System.Drawing.Point(2, 128);
            this.labelEptDelimiter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptDelimiter.Name = "labelEptDelimiter";
            this.labelEptDelimiter.Size = new System.Drawing.Size(47, 35);
            this.labelEptDelimiter.TabIndex = 5;
            this.labelEptDelimiter.Text = "Delimiter";
            // 
            // textEptBoxRow
            // 
            this.textEptBoxRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEptBoxRow.Location = new System.Drawing.Point(159, 2);
            this.textEptBoxRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEptBoxRow.Name = "textEptBoxRow";
            this.textEptBoxRow.Size = new System.Drawing.Size(153, 20);
            this.textEptBoxRow.TabIndex = 7;
            // 
            // textEptBoxCol
            // 
            this.textEptBoxCol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEptBoxCol.Location = new System.Drawing.Point(159, 34);
            this.textEptBoxCol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEptBoxCol.Name = "textEptBoxCol";
            this.textEptBoxCol.Size = new System.Drawing.Size(153, 20);
            this.textEptBoxCol.TabIndex = 8;
            // 
            // textBoxEptDelimiter
            // 
            this.textBoxEptDelimiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEptDelimiter.Location = new System.Drawing.Point(159, 130);
            this.textBoxEptDelimiter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEptDelimiter.Name = "textBoxEptDelimiter";
            this.textBoxEptDelimiter.Size = new System.Drawing.Size(153, 20);
            this.textBoxEptDelimiter.TabIndex = 12;
            // 
            // numericUpDownEptTextIndex
            // 
            this.numericUpDownEptTextIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownEptTextIndex.Location = new System.Drawing.Point(159, 66);
            this.numericUpDownEptTextIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownEptTextIndex.Name = "numericUpDownEptTextIndex";
            this.numericUpDownEptTextIndex.Size = new System.Drawing.Size(153, 20);
            this.numericUpDownEptTextIndex.TabIndex = 13;
            // 
            // numericUpDownEptValueIndex
            // 
            this.numericUpDownEptValueIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownEptValueIndex.Location = new System.Drawing.Point(159, 98);
            this.numericUpDownEptValueIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownEptValueIndex.Name = "numericUpDownEptValueIndex";
            this.numericUpDownEptValueIndex.Size = new System.Drawing.Size(153, 20);
            this.numericUpDownEptValueIndex.TabIndex = 14;
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Location = new System.Drawing.Point(28, 5);
            this.labelGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(44, 13);
            this.labelGeneral.TabIndex = 2;
            this.labelGeneral.Text = "General";
            // 
            // labelEptFormat
            // 
            this.labelEptFormat.AutoSize = true;
            this.labelEptFormat.Location = new System.Drawing.Point(3, 12);
            this.labelEptFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptFormat.Name = "labelEptFormat";
            this.labelEptFormat.Size = new System.Drawing.Size(133, 13);
            this.labelEptFormat.TabIndex = 3;
            this.labelEptFormat.Text = "EPT Result Search Format";
            // 
            // panelEPT
            // 
            this.panelEPT.Controls.Add(this.labelEptPreview);
            this.panelEPT.Controls.Add(this.labelEptFormat);
            this.panelEPT.Controls.Add(this.tableLayoutPanel1);
            this.panelEPT.Location = new System.Drawing.Point(7, 248);
            this.panelEPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEPT.Name = "panelEPT";
            this.panelEPT.Size = new System.Drawing.Size(328, 273);
            this.panelEPT.TabIndex = 4;
            // 
            // labelEptPreview
            // 
            this.labelEptPreview.AutoSize = true;
            this.labelEptPreview.Location = new System.Drawing.Point(14, 220);
            this.labelEptPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptPreview.Name = "labelEptPreview";
            this.labelEptPreview.Size = new System.Drawing.Size(44, 13);
            this.labelEptPreview.TabIndex = 4;
            this.labelEptPreview.Text = "preview";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(250, 540);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(173, 540);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ProcessConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 575);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelEPT);
            this.Controls.Add(this.labelGeneral);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "ConfigForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEptTextIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEptValueIndex)).EndInit();
            this.panelEPT.ResumeLayout(false);
            this.panelEPT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInputSheetName;
        private System.Windows.Forms.Label labelOutputSheetName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInputSheetName;
        private System.Windows.Forms.TextBox textBoxOutputSheetName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEptRow;
        private System.Windows.Forms.Label labelEptCol;
        private System.Windows.Forms.Label labelEptTextIndex;
        private System.Windows.Forms.Label labelEptValueIndex;
        private System.Windows.Forms.Label labelEptDelimiter;
        private System.Windows.Forms.TextBox textEptBoxRow;
        private System.Windows.Forms.TextBox textEptBoxCol;
        private System.Windows.Forms.TextBox textBoxEptDelimiter;
        private System.Windows.Forms.NumericUpDown numericUpDownEptTextIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownEptValueIndex;
        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.Label labelEptFormat;
        private System.Windows.Forms.Panel panelEPT;
        private System.Windows.Forms.Label labelEptPreview;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}