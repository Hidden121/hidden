namespace z12
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
            this.Vvodchisla = new System.Windows.Forms.TextBox();
            this.Vivodchisla = new System.Windows.Forms.Label();
            this.Factorialchisla = new System.Windows.Forms.Button();
            this.Perehod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vvodchisla
            // 
            this.Vvodchisla.Location = new System.Drawing.Point(23, 19);
            this.Vvodchisla.Name = "Vvodchisla";
            this.Vvodchisla.Size = new System.Drawing.Size(100, 20);
            this.Vvodchisla.TabIndex = 0;
            // 
            // Vivodchisla
            // 
            this.Vivodchisla.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Vivodchisla.Location = new System.Drawing.Point(143, 19);
            this.Vivodchisla.Name = "Vivodchisla";
            this.Vivodchisla.Size = new System.Drawing.Size(100, 20);
            this.Vivodchisla.TabIndex = 1;
            // 
            // Factorialchisla
            // 
            this.Factorialchisla.Location = new System.Drawing.Point(23, 61);
            this.Factorialchisla.Name = "Factorialchisla";
            this.Factorialchisla.Size = new System.Drawing.Size(122, 23);
            this.Factorialchisla.TabIndex = 2;
            this.Factorialchisla.Text = "Факториал числа ";
            this.Factorialchisla.UseVisualStyleBackColor = true;
            this.Factorialchisla.Click += new System.EventHandler(this.Factorialchisla_Click);
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(167, 60);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 3;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(304, 109);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Factorialchisla);
            this.Controls.Add(this.Vivodchisla);
            this.Controls.Add(this.Vvodchisla);
            this.Name = "Form1";
            this.Text = "Вычисление факториала числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vvodchisla;
        private System.Windows.Forms.Label Vivodchisla;
        private System.Windows.Forms.Button Factorialchisla;
        private System.Windows.Forms.Button Perehod;
    }
}

