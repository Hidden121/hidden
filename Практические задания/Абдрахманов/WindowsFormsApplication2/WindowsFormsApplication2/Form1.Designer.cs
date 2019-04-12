namespace WindowsFormsApplication2
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
            this.VvodZna4enia = new System.Windows.Forms.Label();
            this.VvodZna4enia2 = new System.Windows.Forms.Label();
            this.VvodZna4enia3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Vvod4isla = new System.Windows.Forms.TextBox();
            this.Vvod4isla2 = new System.Windows.Forms.TextBox();
            this.Vvod4isla3 = new System.Windows.Forms.TextBox();
            this.VivodResulta = new System.Windows.Forms.TextBox();
            this.Vipolnit = new System.Windows.Forms.Button();
            this.Perehod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VvodZna4enia
            // 
            this.VvodZna4enia.AutoSize = true;
            this.VvodZna4enia.Location = new System.Drawing.Point(13, 13);
            this.VvodZna4enia.Name = "VvodZna4enia";
            this.VvodZna4enia.Size = new System.Drawing.Size(112, 13);
            this.VvodZna4enia.TabIndex = 0;
            this.VvodZna4enia.Text = "Введите значение Х:";
            // 
            // VvodZna4enia2
            // 
            this.VvodZna4enia2.AutoSize = true;
            this.VvodZna4enia2.Location = new System.Drawing.Point(13, 44);
            this.VvodZna4enia2.Name = "VvodZna4enia2";
            this.VvodZna4enia2.Size = new System.Drawing.Size(112, 13);
            this.VvodZna4enia2.TabIndex = 1;
            this.VvodZna4enia2.Text = "Введите значение Y:";
            // 
            // VvodZna4enia3
            // 
            this.VvodZna4enia3.AutoSize = true;
            this.VvodZna4enia3.Location = new System.Drawing.Point(13, 75);
            this.VvodZna4enia3.Name = "VvodZna4enia3";
            this.VvodZna4enia3.Size = new System.Drawing.Size(112, 13);
            this.VvodZna4enia3.TabIndex = 2;
            this.VvodZna4enia3.Text = "Введите значение Z:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(13, 108);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(191, 13);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результаты выолнения программы:";
            // 
            // Vvod4isla
            // 
            this.Vvod4isla.Location = new System.Drawing.Point(131, 10);
            this.Vvod4isla.Name = "Vvod4isla";
            this.Vvod4isla.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla.TabIndex = 4;
            // 
            // Vvod4isla2
            // 
            this.Vvod4isla2.Location = new System.Drawing.Point(131, 41);
            this.Vvod4isla2.Name = "Vvod4isla2";
            this.Vvod4isla2.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla2.TabIndex = 5;
            // 
            // Vvod4isla3
            // 
            this.Vvod4isla3.Location = new System.Drawing.Point(131, 75);
            this.Vvod4isla3.Name = "Vvod4isla3";
            this.Vvod4isla3.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla3.TabIndex = 6;
            // 
            // VivodResulta
            // 
            this.VivodResulta.Location = new System.Drawing.Point(16, 124);
            this.VivodResulta.Multiline = true;
            this.VivodResulta.Name = "VivodResulta";
            this.VivodResulta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VivodResulta.Size = new System.Drawing.Size(234, 96);
            this.VivodResulta.TabIndex = 7;
            // 
            // Vipolnit
            // 
            this.Vipolnit.Location = new System.Drawing.Point(175, 226);
            this.Vipolnit.Name = "Vipolnit";
            this.Vipolnit.Size = new System.Drawing.Size(75, 23);
            this.Vipolnit.TabIndex = 8;
            this.Vipolnit.Text = "Выполнить";
            this.Vipolnit.UseVisualStyleBackColor = true;
            this.Vipolnit.Click += new System.EventHandler(this.Vipolnit_Click);
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(49, 226);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 9;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vipolnit);
            this.Controls.Add(this.VivodResulta);
            this.Controls.Add(this.Vvod4isla3);
            this.Controls.Add(this.Vvod4isla2);
            this.Controls.Add(this.Vvod4isla);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.VvodZna4enia3);
            this.Controls.Add(this.VvodZna4enia2);
            this.Controls.Add(this.VvodZna4enia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VvodZna4enia;
        private System.Windows.Forms.Label VvodZna4enia2;
        private System.Windows.Forms.Label VvodZna4enia3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Vvod4isla;
        private System.Windows.Forms.TextBox Vvod4isla2;
        private System.Windows.Forms.TextBox Vvod4isla3;
        private System.Windows.Forms.TextBox VivodResulta;
        private System.Windows.Forms.Button Vipolnit;
        private System.Windows.Forms.Button Perehod;
    }
}

