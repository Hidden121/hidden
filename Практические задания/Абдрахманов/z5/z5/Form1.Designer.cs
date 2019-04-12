namespace z5
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
            this.Vivod = new System.Windows.Forms.Label();
            this.Описание = new System.Windows.Forms.Label();
            this.Artical = new System.Windows.Forms.Label();
            this.Артикул = new System.Windows.Forms.Label();
            this.VivodCeni = new System.Windows.Forms.Label();
            this.ViborPlati = new System.Windows.Forms.ComboBox();
            this.Цена = new System.Windows.Forms.Label();
            this.Модель = new System.Windows.Forms.Label();
            this.Kartinka = new System.Windows.Forms.PictureBox();
            this.Perehod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).BeginInit();
            this.SuspendLayout();
            // 
            // Vivod
            // 
            this.Vivod.BackColor = System.Drawing.SystemColors.Control;
            this.Vivod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Vivod.Location = new System.Drawing.Point(13, 124);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(121, 134);
            this.Vivod.TabIndex = 16;
            // 
            // Описание
            // 
            this.Описание.AutoSize = true;
            this.Описание.Location = new System.Drawing.Point(12, 88);
            this.Описание.Name = "Описание";
            this.Описание.Size = new System.Drawing.Size(57, 13);
            this.Описание.TabIndex = 15;
            this.Описание.Text = "Описание";
            // 
            // Artical
            // 
            this.Artical.BackColor = System.Drawing.SystemColors.Control;
            this.Artical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Artical.Location = new System.Drawing.Point(155, 103);
            this.Artical.Name = "Artical";
            this.Artical.Size = new System.Drawing.Size(120, 22);
            this.Artical.TabIndex = 14;
            // 
            // Артикул
            // 
            this.Артикул.AutoSize = true;
            this.Артикул.Location = new System.Drawing.Point(178, 76);
            this.Артикул.Name = "Артикул";
            this.Артикул.Size = new System.Drawing.Size(48, 13);
            this.Артикул.TabIndex = 13;
            this.Артикул.Text = "Артикул";
            // 
            // VivodCeni
            // 
            this.VivodCeni.BackColor = System.Drawing.SystemColors.Control;
            this.VivodCeni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VivodCeni.Location = new System.Drawing.Point(155, 35);
            this.VivodCeni.Name = "VivodCeni";
            this.VivodCeni.Size = new System.Drawing.Size(120, 23);
            this.VivodCeni.TabIndex = 12;
            // 
            // ViborPlati
            // 
            this.ViborPlati.FormattingEnabled = true;
            this.ViborPlati.Location = new System.Drawing.Point(13, 35);
            this.ViborPlati.Name = "ViborPlati";
            this.ViborPlati.Size = new System.Drawing.Size(121, 21);
            this.ViborPlati.TabIndex = 11;
            this.ViborPlati.SelectedIndexChanged += new System.EventHandler(this.ViborPlati_SelectedIndexChanged);
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(178, 3);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(33, 13);
            this.Цена.TabIndex = 10;
            this.Цена.Text = "Цена";
            // 
            // Модель
            // 
            this.Модель.AutoSize = true;
            this.Модель.Location = new System.Drawing.Point(12, 9);
            this.Модель.Name = "Модель";
            this.Модель.Size = new System.Drawing.Size(46, 13);
            this.Модель.TabIndex = 9;
            this.Модель.Text = "Модель";
            // 
            // Kartinka
            // 
            this.Kartinka.Location = new System.Drawing.Point(155, 138);
            this.Kartinka.Name = "Kartinka";
            this.Kartinka.Size = new System.Drawing.Size(120, 120);
            this.Kartinka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kartinka.TabIndex = 17;
            this.Kartinka.TabStop = false;
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(181, 266);
            this.Perehod.MaximumSize = new System.Drawing.Size(350, 350);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 18;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Kartinka);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Описание);
            this.Controls.Add(this.Artical);
            this.Controls.Add(this.Артикул);
            this.Controls.Add(this.VivodCeni);
            this.Controls.Add(this.ViborPlati);
            this.Controls.Add(this.Цена);
            this.Controls.Add(this.Модель);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "Системная плата";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kartinka;
        private System.Windows.Forms.Label Vivod;
        private System.Windows.Forms.Label Описание;
        private System.Windows.Forms.Label Artical;
        private System.Windows.Forms.Label Артикул;
        private System.Windows.Forms.Label VivodCeni;
        private System.Windows.Forms.ComboBox ViborPlati;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.Label Модель;
        private System.Windows.Forms.Button Perehod;
    }
}

