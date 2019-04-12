namespace z6
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
            this.Info = new System.Windows.Forms.ListBox();
            this.Info2 = new System.Windows.Forms.ListBox();
            this.MuzKrujok = new System.Windows.Forms.Label();
            this.TancevalKrujok = new System.Windows.Forms.Label();
            this.FormirovanieGrupp = new System.Windows.Forms.Button();
            this.ObaKrujka = new System.Windows.Forms.Button();
            this.lubieKrujki = new System.Windows.Forms.Button();
            this.TolikoMuzika = new System.Windows.Forms.Button();
            this.TolikoTanci = new System.Windows.Forms.Button();
            this.Info3 = new System.Windows.Forms.ListBox();
            this.Kolvostudentovvmuzike = new System.Windows.Forms.Button();
            this.Kolvostudentovvkrujketanci = new System.Windows.Forms.Button();
            this.Tolko1krujok = new System.Windows.Forms.Button();
            this.Ukazaniistudent = new System.Windows.Forms.Button();
            this.napisattext = new System.Windows.Forms.TextBox();
            this.Kolvostudentovvkrujkemuziki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.Location = new System.Drawing.Point(16, 51);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(120, 95);
            this.Info.TabIndex = 0;
            // 
            // Info2
            // 
            this.Info2.FormattingEnabled = true;
            this.Info2.Location = new System.Drawing.Point(16, 195);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(120, 95);
            this.Info2.TabIndex = 1;
            // 
            // MuzKrujok
            // 
            this.MuzKrujok.AutoSize = true;
            this.MuzKrujok.Location = new System.Drawing.Point(13, 9);
            this.MuzKrujok.Name = "MuzKrujok";
            this.MuzKrujok.Size = new System.Drawing.Size(119, 13);
            this.MuzKrujok.TabIndex = 2;
            this.MuzKrujok.Text = "Музыкальный кружок";
            // 
            // TancevalKrujok
            // 
            this.TancevalKrujok.AutoSize = true;
            this.TancevalKrujok.Location = new System.Drawing.Point(13, 163);
            this.TancevalKrujok.Name = "TancevalKrujok";
            this.TancevalKrujok.Size = new System.Drawing.Size(122, 13);
            this.TancevalKrujok.TabIndex = 3;
            this.TancevalKrujok.Text = "Танцевальный кружок";
            // 
            // FormirovanieGrupp
            // 
            this.FormirovanieGrupp.Location = new System.Drawing.Point(12, 315);
            this.FormirovanieGrupp.Name = "FormirovanieGrupp";
            this.FormirovanieGrupp.Size = new System.Drawing.Size(137, 23);
            this.FormirovanieGrupp.TabIndex = 4;
            this.FormirovanieGrupp.Text = "Формирование групп";
            this.FormirovanieGrupp.UseVisualStyleBackColor = true;
            this.FormirovanieGrupp.Click += new System.EventHandler(this.FormirovanieGrupp_Click);
            // 
            // ObaKrujka
            // 
            this.ObaKrujka.Location = new System.Drawing.Point(191, 75);
            this.ObaKrujka.Name = "ObaKrujka";
            this.ObaKrujka.Size = new System.Drawing.Size(151, 23);
            this.ObaKrujka.TabIndex = 6;
            this.ObaKrujka.Text = "Посещают оба кружка";
            this.ObaKrujka.UseVisualStyleBackColor = true;
            this.ObaKrujka.Click += new System.EventHandler(this.ObaKrujka_Click);
            // 
            // lubieKrujki
            // 
            this.lubieKrujki.Location = new System.Drawing.Point(191, 46);
            this.lubieKrujki.Name = "lubieKrujki";
            this.lubieKrujki.Size = new System.Drawing.Size(151, 23);
            this.lubieKrujki.TabIndex = 7;
            this.lubieKrujki.Text = "Посещают любые кружки";
            this.lubieKrujki.UseVisualStyleBackColor = true;
            this.lubieKrujki.Click += new System.EventHandler(this.lubieKrujki_Click);
            // 
            // TolikoMuzika
            // 
            this.TolikoMuzika.Location = new System.Drawing.Point(191, 104);
            this.TolikoMuzika.Name = "TolikoMuzika";
            this.TolikoMuzika.Size = new System.Drawing.Size(151, 23);
            this.TolikoMuzika.TabIndex = 8;
            this.TolikoMuzika.Text = "Только музыкальный";
            this.TolikoMuzika.UseVisualStyleBackColor = true;
            this.TolikoMuzika.Click += new System.EventHandler(this.TolikoMuzika_Click);
            // 
            // TolikoTanci
            // 
            this.TolikoTanci.Location = new System.Drawing.Point(191, 133);
            this.TolikoTanci.Name = "TolikoTanci";
            this.TolikoTanci.Size = new System.Drawing.Size(151, 23);
            this.TolikoTanci.TabIndex = 9;
            this.TolikoTanci.Text = "Только танцы";
            this.TolikoTanci.UseVisualStyleBackColor = true;
            this.TolikoTanci.Click += new System.EventHandler(this.TolikoTanci_Click);
            // 
            // Info3
            // 
            this.Info3.FormattingEnabled = true;
            this.Info3.Location = new System.Drawing.Point(191, 195);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(396, 95);
            this.Info3.TabIndex = 10;
            // 
            // Kolvostudentovvmuzike
            // 
            this.Kolvostudentovvmuzike.Location = new System.Drawing.Point(376, 45);
            this.Kolvostudentovvmuzike.Name = "Kolvostudentovvmuzike";
            this.Kolvostudentovvmuzike.Size = new System.Drawing.Size(211, 24);
            this.Kolvostudentovvmuzike.TabIndex = 11;
            this.Kolvostudentovvmuzike.Text = "Кол-во студентов в кружке музыки";
            this.Kolvostudentovvmuzike.UseVisualStyleBackColor = true;
            this.Kolvostudentovvmuzike.Click += new System.EventHandler(this.Kolvostudentovvmuzike_Click);
            // 
            // Kolvostudentovvkrujketanci
            // 
            this.Kolvostudentovvkrujketanci.Location = new System.Drawing.Point(376, 74);
            this.Kolvostudentovvkrujketanci.Name = "Kolvostudentovvkrujketanci";
            this.Kolvostudentovvkrujketanci.Size = new System.Drawing.Size(211, 23);
            this.Kolvostudentovvkrujketanci.TabIndex = 12;
            this.Kolvostudentovvkrujketanci.Text = "Кол-во студентов в кружке танцы";
            this.Kolvostudentovvkrujketanci.UseVisualStyleBackColor = true;
            this.Kolvostudentovvkrujketanci.Click += new System.EventHandler(this.Kolvostudentovvkrujketanci_Click);
            // 
            // Tolko1krujok
            // 
            this.Tolko1krujok.Location = new System.Drawing.Point(376, 103);
            this.Tolko1krujok.Name = "Tolko1krujok";
            this.Tolko1krujok.Size = new System.Drawing.Size(211, 23);
            this.Tolko1krujok.TabIndex = 13;
            this.Tolko1krujok.Text = "Посещают только один кружок";
            this.Tolko1krujok.UseVisualStyleBackColor = true;
            this.Tolko1krujok.Click += new System.EventHandler(this.Tolko1krujok_Click);
            // 
            // Ukazaniistudent
            // 
            this.Ukazaniistudent.Location = new System.Drawing.Point(376, 133);
            this.Ukazaniistudent.Name = "Ukazaniistudent";
            this.Ukazaniistudent.Size = new System.Drawing.Size(211, 23);
            this.Ukazaniistudent.TabIndex = 14;
            this.Ukazaniistudent.Text = "Музыку посещает указанный студент";
            this.Ukazaniistudent.UseVisualStyleBackColor = true;
            this.Ukazaniistudent.Click += new System.EventHandler(this.Ukazaniistudent_Click);
            // 
            // napisattext
            // 
            this.napisattext.Location = new System.Drawing.Point(376, 169);
            this.napisattext.Name = "napisattext";
            this.napisattext.Size = new System.Drawing.Size(211, 20);
            this.napisattext.TabIndex = 15;
            // 
            // Kolvostudentovvkrujkemuziki
            // 
            this.Kolvostudentovvkrujkemuziki.AutoSize = true;
            this.Kolvostudentovvkrujkemuziki.Location = new System.Drawing.Point(209, 315);
            this.Kolvostudentovvkrujkemuziki.Name = "Kolvostudentovvkrujkemuziki";
            this.Kolvostudentovvkrujkemuziki.Size = new System.Drawing.Size(186, 13);
            this.Kolvostudentovvkrujkemuziki.TabIndex = 16;
            this.Kolvostudentovvkrujkemuziki.Text = "Кол-во студентов в кружке музыки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 345);
            this.Controls.Add(this.Kolvostudentovvkrujkemuziki);
            this.Controls.Add(this.napisattext);
            this.Controls.Add(this.Ukazaniistudent);
            this.Controls.Add(this.Tolko1krujok);
            this.Controls.Add(this.Kolvostudentovvkrujketanci);
            this.Controls.Add(this.Kolvostudentovvmuzike);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.TolikoTanci);
            this.Controls.Add(this.TolikoMuzika);
            this.Controls.Add(this.lubieKrujki);
            this.Controls.Add(this.ObaKrujka);
            this.Controls.Add(this.FormirovanieGrupp);
            this.Controls.Add(this.TancevalKrujok);
            this.Controls.Add(this.MuzKrujok);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info);
            this.MaximumSize = new System.Drawing.Size(690, 372);
            this.MinimumSize = new System.Drawing.Size(690, 372);
            this.Name = "Form1";
            this.Text = "Занятия в кружках";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Info;
        private System.Windows.Forms.ListBox Info2;
        private System.Windows.Forms.Label MuzKrujok;
        private System.Windows.Forms.Label TancevalKrujok;
        private System.Windows.Forms.Button FormirovanieGrupp;
        private System.Windows.Forms.Button ObaKrujka;
        private System.Windows.Forms.Button lubieKrujki;
        private System.Windows.Forms.Button TolikoMuzika;
        private System.Windows.Forms.Button TolikoTanci;
        private System.Windows.Forms.ListBox Info3;
        private System.Windows.Forms.Button Kolvostudentovvmuzike;
        private System.Windows.Forms.Button Kolvostudentovvkrujketanci;
        private System.Windows.Forms.Button Tolko1krujok;
        private System.Windows.Forms.Button Ukazaniistudent;
        private System.Windows.Forms.TextBox napisattext;
        private System.Windows.Forms.Label Kolvostudentovvkrujkemuziki;
    }
}

