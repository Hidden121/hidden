namespace z7
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
            this.O4istit = new System.Windows.Forms.Button();
            this.Zapisat = new System.Windows.Forms.Button();
            this.Pro4itat = new System.Windows.Forms.Button();
            this.VivodResultata = new System.Windows.Forms.Label();
            this.Vvodtexta = new System.Windows.Forms.TextBox();
            this.Perehod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // O4istit
            // 
            this.O4istit.Location = new System.Drawing.Point(22, 12);
            this.O4istit.Name = "O4istit";
            this.O4istit.Size = new System.Drawing.Size(75, 23);
            this.O4istit.TabIndex = 0;
            this.O4istit.Text = "Очистить";
            this.O4istit.UseVisualStyleBackColor = true;
            this.O4istit.Click += new System.EventHandler(this.O4istit_Click);
            // 
            // Zapisat
            // 
            this.Zapisat.Location = new System.Drawing.Point(22, 97);
            this.Zapisat.Name = "Zapisat";
            this.Zapisat.Size = new System.Drawing.Size(75, 23);
            this.Zapisat.TabIndex = 1;
            this.Zapisat.Text = "Записать";
            this.Zapisat.UseVisualStyleBackColor = true;
            this.Zapisat.Click += new System.EventHandler(this.Zapisat_Click);
            // 
            // Pro4itat
            // 
            this.Pro4itat.Location = new System.Drawing.Point(22, 163);
            this.Pro4itat.Name = "Pro4itat";
            this.Pro4itat.Size = new System.Drawing.Size(75, 23);
            this.Pro4itat.TabIndex = 2;
            this.Pro4itat.Text = "Прочитать";
            this.Pro4itat.UseVisualStyleBackColor = true;
            this.Pro4itat.Click += new System.EventHandler(this.Pro4itat_Click);
            // 
            // VivodResultata
            // 
            this.VivodResultata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VivodResultata.Location = new System.Drawing.Point(142, 33);
            this.VivodResultata.Name = "VivodResultata";
            this.VivodResultata.Size = new System.Drawing.Size(143, 153);
            this.VivodResultata.TabIndex = 3;
            // 
            // Vvodtexta
            // 
            this.Vvodtexta.Location = new System.Drawing.Point(22, 55);
            this.Vvodtexta.Name = "Vvodtexta";
            this.Vvodtexta.Size = new System.Drawing.Size(101, 20);
            this.Vvodtexta.TabIndex = 4;
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(22, 226);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 5;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(322, 303);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vvodtexta);
            this.Controls.Add(this.VivodResultata);
            this.Controls.Add(this.Pro4itat);
            this.Controls.Add(this.Zapisat);
            this.Controls.Add(this.O4istit);
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чтение-запись";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button O4istit;
        private System.Windows.Forms.Button Zapisat;
        private System.Windows.Forms.Button Pro4itat;
        private System.Windows.Forms.Label VivodResultata;
        private System.Windows.Forms.TextBox Vvodtexta;
        private System.Windows.Forms.Button Perehod;
    }
}

