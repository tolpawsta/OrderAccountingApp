namespace CSVGenerateApp
{
    partial class CSVGenerateAppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPathToTargetCsv = new System.Windows.Forms.Label();
            this.txtPath2Souce4CsvFile = new System.Windows.Forms.TextBox();
            this.txtCountFiles = new System.Windows.Forms.TextBox();
            this.lblCountFiles = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPathToTargetCsv
            // 
            this.lblPathToTargetCsv.AutoSize = true;
            this.lblPathToTargetCsv.Location = new System.Drawing.Point(47, 48);
            this.lblPathToTargetCsv.Name = "lblPathToTargetCsv";
            this.lblPathToTargetCsv.Size = new System.Drawing.Size(92, 13);
            this.lblPathToTargetCsv.TabIndex = 0;
            this.lblPathToTargetCsv.Text = "PathToTargetScv";
            // 
            // txtPath2Souce4CsvFile
            // 
            this.txtPath2Souce4CsvFile.Location = new System.Drawing.Point(149, 8);
            this.txtPath2Souce4CsvFile.Multiline = true;
            this.txtPath2Souce4CsvFile.Name = "txtPath2Souce4CsvFile";
            this.txtPath2Souce4CsvFile.Size = new System.Drawing.Size(451, 20);
            this.txtPath2Souce4CsvFile.TabIndex = 1;
            // 
            // txtCountFiles
            // 
            this.txtCountFiles.Location = new System.Drawing.Point(148, 81);
            this.txtCountFiles.Name = "txtCountFiles";
            this.txtCountFiles.Size = new System.Drawing.Size(99, 20);
            this.txtCountFiles.TabIndex = 2;
            // 
            // lblCountFiles
            // 
            this.lblCountFiles.AutoSize = true;
            this.lblCountFiles.Location = new System.Drawing.Point(83, 84);
            this.lblCountFiles.Name = "lblCountFiles";
            this.lblCountFiles.Size = new System.Drawing.Size(56, 13);
            this.lblCountFiles.TabIndex = 3;
            this.lblCountFiles.Text = "CountFiles";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(263, 81);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(335, 39);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(14, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(130, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "PathToSourceForCsvFiles";
            // 
            // CSVGenerateAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 132);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblCountFiles);
            this.Controls.Add(this.txtCountFiles);
            this.Controls.Add(this.txtPath2Souce4CsvFile);
            this.Controls.Add(this.lblPathToTargetCsv);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CSVGenerateAppForm";
            this.Text = "CSVGenerateApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathToTargetCsv;
        private System.Windows.Forms.TextBox txtPath2Souce4CsvFile;
        private System.Windows.Forms.TextBox txtCountFiles;
        private System.Windows.Forms.Label lblCountFiles;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl;
    }
}

