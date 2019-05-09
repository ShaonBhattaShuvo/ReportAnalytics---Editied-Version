namespace DV_ReportAnalytics.Views.ProcessPanels
{
    partial class EPTProcess
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
            this.labelOutputSheetName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInputSheetName = new System.Windows.Forms.TextBox();
            this.textBoxOutputSheetName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxEptDelimiter = new System.Windows.Forms.TextBox();
            this.labelEptTextIndex = new System.Windows.Forms.Label();
            this.labelEptValueIndex = new System.Windows.Forms.Label();
            this.labelEptDelimiter = new System.Windows.Forms.Label();
            this.labelEptCol = new System.Windows.Forms.Label();
            this.numericUpDownEptTextIndex = new System.Windows.Forms.NumericUpDown();
            this.textEptBoxCol = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEptTextIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Location = new System.Drawing.Point(2, 0);
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
            this.tableLayoutPanel.Controls.Add(this.textBoxEptDelimiter, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelOutputSheetName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxInputSheetName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxOutputSheetName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelType, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelEptTextIndex, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.labelEptDelimiter, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelEptCol, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelEptValueIndex, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.textEptBoxCol, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownEptTextIndex, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.numericUpDown1, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(22, 94);
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(390, 437);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(4, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(187, 53);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInputSheetName
            // 
            this.labelInputSheetName.AutoSize = true;
            this.labelInputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInputSheetName.Location = new System.Drawing.Point(4, 109);
            this.labelInputSheetName.Name = "labelInputSheetName";
            this.labelInputSheetName.Size = new System.Drawing.Size(187, 53);
            this.labelInputSheetName.TabIndex = 3;
            this.labelInputSheetName.Text = "Input Sheet Name";
            this.labelInputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOutputSheetName
            // 
            this.labelOutputSheetName.AutoSize = true;
            this.labelOutputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutputSheetName.Location = new System.Drawing.Point(4, 163);
            this.labelOutputSheetName.Name = "labelOutputSheetName";
            this.labelOutputSheetName.Size = new System.Drawing.Size(187, 53);
            this.labelOutputSheetName.TabIndex = 4;
            this.labelOutputSheetName.Text = "Output Sheet Name";
            this.labelOutputSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(198, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "EPT Report Results";
            // 
            // textBoxInputSheetName
            // 
            this.textBoxInputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInputSheetName.Location = new System.Drawing.Point(198, 112);
            this.textBoxInputSheetName.Name = "textBoxInputSheetName";
            this.textBoxInputSheetName.Size = new System.Drawing.Size(188, 20);
            this.textBoxInputSheetName.TabIndex = 8;
            this.textBoxInputSheetName.Text = "Results";
            // 
            // textBoxOutputSheetName
            // 
            this.textBoxOutputSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutputSheetName.Location = new System.Drawing.Point(198, 166);
            this.textBoxOutputSheetName.Name = "textBoxOutputSheetName";
            this.textBoxOutputSheetName.Size = new System.Drawing.Size(188, 20);
            this.textBoxOutputSheetName.TabIndex = 9;
            this.textBoxOutputSheetName.Text = "Combined Results";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(4, 1);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(187, 53);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxEptDelimiter
            // 
            this.textBoxEptDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEptDelimiter.Location = new System.Drawing.Point(197, 273);
            this.textBoxEptDelimiter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEptDelimiter.Name = "textBoxEptDelimiter";
            this.textBoxEptDelimiter.Size = new System.Drawing.Size(190, 20);
            this.textBoxEptDelimiter.TabIndex = 12;
            // 
            // labelEptTextIndex
            // 
            this.labelEptTextIndex.AutoSize = true;
            this.labelEptTextIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEptTextIndex.Location = new System.Drawing.Point(3, 325);
            this.labelEptTextIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptTextIndex.Name = "labelEptTextIndex";
            this.labelEptTextIndex.Size = new System.Drawing.Size(189, 53);
            this.labelEptTextIndex.TabIndex = 12;
            this.labelEptTextIndex.Text = "Text Index";
            this.labelEptTextIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEptValueIndex
            // 
            this.labelEptValueIndex.AutoSize = true;
            this.labelEptValueIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEptValueIndex.Location = new System.Drawing.Point(3, 379);
            this.labelEptValueIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptValueIndex.Name = "labelEptValueIndex";
            this.labelEptValueIndex.Size = new System.Drawing.Size(189, 57);
            this.labelEptValueIndex.TabIndex = 13;
            this.labelEptValueIndex.Text = "Value Index";
            this.labelEptValueIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEptDelimiter
            // 
            this.labelEptDelimiter.AutoSize = true;
            this.labelEptDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEptDelimiter.Location = new System.Drawing.Point(3, 271);
            this.labelEptDelimiter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptDelimiter.Name = "labelEptDelimiter";
            this.labelEptDelimiter.Size = new System.Drawing.Size(189, 53);
            this.labelEptDelimiter.TabIndex = 14;
            this.labelEptDelimiter.Text = "Delimiter";
            this.labelEptDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEptCol
            // 
            this.labelEptCol.AutoSize = true;
            this.labelEptCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEptCol.Location = new System.Drawing.Point(3, 217);
            this.labelEptCol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEptCol.Name = "labelEptCol";
            this.labelEptCol.Size = new System.Drawing.Size(189, 53);
            this.labelEptCol.TabIndex = 15;
            this.labelEptCol.Text = "Text";
            this.labelEptCol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownEptTextIndex
            // 
            this.numericUpDownEptTextIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownEptTextIndex.Location = new System.Drawing.Point(197, 327);
            this.numericUpDownEptTextIndex.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownEptTextIndex.Name = "numericUpDownEptTextIndex";
            this.numericUpDownEptTextIndex.Size = new System.Drawing.Size(190, 20);
            this.numericUpDownEptTextIndex.TabIndex = 16;
            // 
            // textEptBoxCol
            // 
            this.textEptBoxCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEptBoxCol.Location = new System.Drawing.Point(197, 219);
            this.textEptBoxCol.Margin = new System.Windows.Forms.Padding(2);
            this.textEptBoxCol.Name = "textEptBoxCol";
            this.textEptBoxCol.Size = new System.Drawing.Size(190, 20);
            this.textEptBoxCol.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(198, 382);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(188, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(198, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 20;
            // 
            // EPTProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelGeneral);
            this.Name = "EPTProcess";
            this.Size = new System.Drawing.Size(415, 583);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEptTextIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxEptDelimiter;
        private System.Windows.Forms.Label labelEptTextIndex;
        private System.Windows.Forms.Label labelEptDelimiter;
        private System.Windows.Forms.Label labelEptCol;
        private System.Windows.Forms.Label labelEptValueIndex;
        private System.Windows.Forms.TextBox textEptBoxCol;
        private System.Windows.Forms.NumericUpDown numericUpDownEptTextIndex;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
