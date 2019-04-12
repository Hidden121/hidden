namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.Perehod = new System.Windows.Forms.Button();
            this.Vipolnit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Vvod4isla3 = new System.Windows.Forms.TextBox();
            this.Vvod4isla2 = new System.Windows.Forms.TextBox();
            this.Vvod4isla = new System.Windows.Forms.TextBox();
            this.ResultVipolnenia = new System.Windows.Forms.Label();
            this.Vvodzna4enia3 = new System.Windows.Forms.Label();
            this.Vvodzna4enia2 = new System.Windows.Forms.Label();
            this.Vvodzna4enia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(60, 227);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 19;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Vipolnit
            // 
            this.Vipolnit.Location = new System.Drawing.Point(186, 227);
            this.Vipolnit.Name = "Vipolnit";
            this.Vipolnit.Size = new System.Drawing.Size(75, 23);
            this.Vipolnit.TabIndex = 18;
            this.Vipolnit.Text = "Выполнить";
            this.Vipolnit.UseVisualStyleBackColor = true;
            this.Vipolnit.Click += new System.EventHandler(this.Vipolnit_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(27, 125);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(234, 96);
            this.Result.TabIndex = 17;
            // 
            // Vvod4isla3
            // 
            this.Vvod4isla3.Location = new System.Drawing.Point(142, 76);
            this.Vvod4isla3.Name = "Vvod4isla3";
            this.Vvod4isla3.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla3.TabIndex = 16;
            // 
            // Vvod4isla2
            // 
            this.Vvod4isla2.Location = new System.Drawing.Point(142, 42);
            this.Vvod4isla2.Name = "Vvod4isla2";
            this.Vvod4isla2.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla2.TabIndex = 15;
            // 
            // Vvod4isla
            // 
            this.Vvod4isla.Location = new System.Drawing.Point(142, 11);
            this.Vvod4isla.Name = "Vvod4isla";
            this.Vvod4isla.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla.TabIndex = 14;
            // 
            // ResultVipolnenia
            // 
            this.ResultVipolnenia.AutoSize = true;
            this.ResultVipolnenia.Location = new System.Drawing.Point(24, 109);
            this.ResultVipolnenia.Name = "ResultVipolnenia";
            this.ResultVipolnenia.Size = new System.Drawing.Size(191, 13);
            this.ResultVipolnenia.TabIndex = 13;
            this.ResultVipolnenia.Text = "Результаты выолнения программы:";
            // 
            // Vvodzna4enia3
            // 
            this.Vvodzna4enia3.AutoSize = true;
            this.Vvodzna4enia3.Location = new System.Drawing.Point(24, 76);
            this.Vvodzna4enia3.Name = "Vvodzna4enia3";
            this.Vvodzna4enia3.Size = new System.Drawing.Size(112, 13);
            this.Vvodzna4enia3.TabIndex = 12;
            this.Vvodzna4enia3.Text = "Введите значение Z:";
            // 
            // Vvodzna4enia2
            // 
            this.Vvodzna4enia2.AutoSize = true;
            this.Vvodzna4enia2.Location = new System.Drawing.Point(24, 45);
            this.Vvodzna4enia2.Name = "Vvodzna4enia2";
            this.Vvodzna4enia2.Size = new System.Drawing.Size(112, 13);
            this.Vvodzna4enia2.TabIndex = 11;
            this.Vvodzna4enia2.Text = "Введите значение Y:";
            // 
            // Vvodzna4enia
            // 
            this.Vvodzna4enia.AutoSize = true;
            this.Vvodzna4enia.Location = new System.Drawing.Point(24, 14);
            this.Vvodzna4enia.Name = "Vvodzna4enia";
            this.Vvodzna4enia.Size = new System.Drawing.Size(112, 13);
            this.Vvodzna4enia.TabIndex = 10;
            this.Vvodzna4enia.Text = "Введите значение Х:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vipolnit);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Vvod4isla3);
            this.Controls.Add(this.Vvod4isla2);
            this.Controls.Add(this.Vvod4isla);
            this.Controls.Add(this.ResultVipolnenia);
            this.Controls.Add(this.Vvodzna4enia3);
            this.Controls.Add(this.Vvodzna4enia2);
            this.Controls.Add(this.Vvodzna4enia);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.Button Vipolnit;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Vvod4isla3;
        private System.Windows.Forms.TextBox Vvod4isla2;
        private System.Windows.Forms.TextBox Vvod4isla;
        private System.Windows.Forms.Label ResultVipolnenia;
        private System.Windows.Forms.Label Vvodzna4enia3;
        private System.Windows.Forms.Label Vvodzna4enia2;
        private System.Windows.Forms.Label Vvodzna4enia;
    }
}