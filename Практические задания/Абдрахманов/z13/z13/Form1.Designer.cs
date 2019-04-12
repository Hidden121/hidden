namespace z13
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Okno = new System.Windows.Forms.ListBox();
            this.Summa = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Label();
            this.Otvet = new System.Windows.Forms.Label();
            this.Dalee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Location = new System.Drawing.Point(13, 13);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(120, 134);
            this.Okno.TabIndex = 0;
            // 
            // Summa
            // 
            this.Summa.Location = new System.Drawing.Point(142, 13);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(75, 23);
            this.Summa.TabIndex = 1;
            this.Summa.Text = "Сумма";
            this.Summa.UseVisualStyleBackColor = true;
            this.Summa.Click += new System.EventHandler(this.Summa_Click);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(139, 44);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(53, 13);
            this.Sum.TabIndex = 2;
            this.Sum.Text = "Сумма = ";
            // 
            // Otvet
            // 
            this.Otvet.Location = new System.Drawing.Point(198, 43);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(74, 23);
            this.Otvet.TabIndex = 3;
            // 
            // Dalee
            // 
            this.Dalee.Location = new System.Drawing.Point(142, 95);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(75, 23);
            this.Dalee.TabIndex = 4;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.Dalee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.Okno);
            this.Name = "Form1";
            this.Text = "Случайные числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.Button Summa;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Otvet;
        private System.Windows.Forms.Button Dalee;
    }
}

