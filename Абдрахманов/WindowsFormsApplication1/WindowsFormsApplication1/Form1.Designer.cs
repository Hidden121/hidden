namespace WindowsFormsApplication1
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
            this.Zapustit = new System.Windows.Forms.Button();
            this.VivodKolvoProbelov = new System.Windows.Forms.Label();
            this.Perehod = new System.Windows.Forms.Button();
            this.VvodTexta = new System.Windows.Forms.TextBox();
            this.KnopkaDobavlenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Items.AddRange(new object[] {
            "Мама мыла раму",
            "Привет мир!",
            "Томский политехнический университет",
            "Visual C#"});
            this.Okno.Location = new System.Drawing.Point(13, 13);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(233, 173);
            this.Okno.TabIndex = 0;
            this.Okno.SelectedIndexChanged += new System.EventHandler(this.Okno_SelectedIndexChanged);
            // 
            // Zapustit
            // 
            this.Zapustit.Location = new System.Drawing.Point(12, 226);
            this.Zapustit.Name = "Zapustit";
            this.Zapustit.Size = new System.Drawing.Size(75, 23);
            this.Zapustit.TabIndex = 1;
            this.Zapustit.Text = "Пуск";
            this.Zapustit.UseVisualStyleBackColor = true;
            this.Zapustit.Click += new System.EventHandler(this.Zapustit_Click);
            // 
            // VivodKolvoProbelov
            // 
            this.VivodKolvoProbelov.AutoSize = true;
            this.VivodKolvoProbelov.Location = new System.Drawing.Point(145, 236);
            this.VivodKolvoProbelov.Name = "VivodKolvoProbelov";
            this.VivodKolvoProbelov.Size = new System.Drawing.Size(120, 13);
            this.VivodKolvoProbelov.TabIndex = 2;
            this.VivodKolvoProbelov.Text = "Количество  пробелов";
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(148, 198);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(124, 23);
            this.Perehod.TabIndex = 3;
            this.Perehod.Text = "Переход на form2";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // VvodTexta
            // 
            this.VvodTexta.Location = new System.Drawing.Point(42, 198);
            this.VvodTexta.Name = "VvodTexta";
            this.VvodTexta.Size = new System.Drawing.Size(100, 20);
            this.VvodTexta.TabIndex = 7;
            // 
            // KnopkaDobavlenia
            // 
            this.KnopkaDobavlenia.Location = new System.Drawing.Point(10, 198);
            this.KnopkaDobavlenia.Name = "KnopkaDobavlenia";
            this.KnopkaDobavlenia.Size = new System.Drawing.Size(26, 23);
            this.KnopkaDobavlenia.TabIndex = 6;
            this.KnopkaDobavlenia.Text = "@";
            this.KnopkaDobavlenia.UseVisualStyleBackColor = true;
            this.KnopkaDobavlenia.Click += new System.EventHandler(this.KnopkaDobavlenia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.VvodTexta);
            this.Controls.Add(this.KnopkaDobavlenia);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.VivodKolvoProbelov);
            this.Controls.Add(this.Zapustit);
            this.Controls.Add(this.Okno);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Обработка строк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.Button Zapustit;
        private System.Windows.Forms.Label VivodKolvoProbelov;
        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.TextBox VvodTexta;
        private System.Windows.Forms.Button KnopkaDobavlenia;
    }
}

