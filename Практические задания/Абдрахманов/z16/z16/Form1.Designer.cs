namespace z16
{
    partial class Form1
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
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Vvod2 = new System.Windows.Forms.TextBox();
            this.Chislo = new System.Windows.Forms.Label();
            this.Chislo2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vicheslit = new System.Windows.Forms.Button();
            this.Perehod = new System.Windows.Forms.Button();
            this.Chastnoe = new System.Windows.Forms.Label();
            this.Ostatok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(95, 12);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 0;
            // 
            // Vvod2
            // 
            this.Vvod2.Location = new System.Drawing.Point(95, 51);
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Size = new System.Drawing.Size(100, 20);
            this.Vvod2.TabIndex = 1;
            // 
            // Chislo
            // 
            this.Chislo.AutoSize = true;
            this.Chislo.Location = new System.Drawing.Point(12, 15);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(48, 13);
            this.Chislo.TabIndex = 2;
            this.Chislo.Text = "Число 1";
            // 
            // Chislo2
            // 
            this.Chislo2.AutoSize = true;
            this.Chislo2.Location = new System.Drawing.Point(12, 54);
            this.Chislo2.Name = "Chislo2";
            this.Chislo2.Size = new System.Drawing.Size(48, 13);
            this.Chislo2.TabIndex = 3;
            this.Chislo2.Text = "Число 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Частное";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Остаток";
            // 
            // Vicheslit
            // 
            this.Vicheslit.Location = new System.Drawing.Point(15, 189);
            this.Vicheslit.Name = "Vicheslit";
            this.Vicheslit.Size = new System.Drawing.Size(75, 23);
            this.Vicheslit.TabIndex = 8;
            this.Vicheslit.Text = "Вычислить";
            this.Vicheslit.UseVisualStyleBackColor = true;
            this.Vicheslit.Click += new System.EventHandler(this.Vicheslit_Click);
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(120, 189);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 9;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Chastnoe
            // 
            this.Chastnoe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Chastnoe.Location = new System.Drawing.Point(95, 93);
            this.Chastnoe.Name = "Chastnoe";
            this.Chastnoe.Size = new System.Drawing.Size(100, 23);
            this.Chastnoe.TabIndex = 10;
            // 
            // Ostatok
            // 
            this.Ostatok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ostatok.Location = new System.Drawing.Point(95, 139);
            this.Ostatok.Name = "Ostatok";
            this.Ostatok.Size = new System.Drawing.Size(100, 23);
            this.Ostatok.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Ostatok);
            this.Controls.Add(this.Chastnoe);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vicheslit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chislo2);
            this.Controls.Add(this.Chislo);
            this.Controls.Add(this.Vvod2);
            this.Controls.Add(this.Vvod);
            this.Name = "Form1";
            this.Text = "Деление с остатком";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.TextBox Vvod2;
        private System.Windows.Forms.Label Chislo;
        private System.Windows.Forms.Label Chislo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Vicheslit;
        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.Label Chastnoe;
        private System.Windows.Forms.Label Ostatok;
    }
}

