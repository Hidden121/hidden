namespace z5
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
            this.Kartinka = new System.Windows.Forms.PictureBox();
            this.Opisanie = new System.Windows.Forms.Label();
            this.Описание = new System.Windows.Forms.Label();
            this.Artical = new System.Windows.Forms.Label();
            this.Артикул = new System.Windows.Forms.Label();
            this.VivodCeni = new System.Windows.Forms.Label();
            this.ViborKorpusa = new System.Windows.Forms.ComboBox();
            this.Цена = new System.Windows.Forms.Label();
            this.Модель = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).BeginInit();
            this.SuspendLayout();
            // 
            // Kartinka
            // 
            this.Kartinka.Location = new System.Drawing.Point(164, 160);
            this.Kartinka.Name = "Kartinka";
            this.Kartinka.Size = new System.Drawing.Size(120, 120);
            this.Kartinka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kartinka.TabIndex = 26;
            this.Kartinka.TabStop = false;
            // 
            // Opisanie
            // 
            this.Opisanie.BackColor = System.Drawing.SystemColors.Control;
            this.Opisanie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Opisanie.Location = new System.Drawing.Point(22, 146);
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Size = new System.Drawing.Size(121, 134);
            this.Opisanie.TabIndex = 25;
            // 
            // Описание
            // 
            this.Описание.AutoSize = true;
            this.Описание.Location = new System.Drawing.Point(21, 110);
            this.Описание.Name = "Описание";
            this.Описание.Size = new System.Drawing.Size(57, 13);
            this.Описание.TabIndex = 24;
            this.Описание.Text = "Описание";
            // 
            // Artical
            // 
            this.Artical.BackColor = System.Drawing.SystemColors.Control;
            this.Artical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Artical.Location = new System.Drawing.Point(164, 120);
            this.Artical.Name = "Artical";
            this.Artical.Size = new System.Drawing.Size(120, 22);
            this.Artical.TabIndex = 23;
            // 
            // Артикул
            // 
            this.Артикул.AutoSize = true;
            this.Артикул.Location = new System.Drawing.Point(187, 91);
            this.Артикул.Name = "Артикул";
            this.Артикул.Size = new System.Drawing.Size(48, 13);
            this.Артикул.TabIndex = 22;
            this.Артикул.Text = "Артикул";
            // 
            // VivodCeni
            // 
            this.VivodCeni.BackColor = System.Drawing.SystemColors.Control;
            this.VivodCeni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VivodCeni.Location = new System.Drawing.Point(164, 53);
            this.VivodCeni.Name = "VivodCeni";
            this.VivodCeni.Size = new System.Drawing.Size(120, 23);
            this.VivodCeni.TabIndex = 21;
            // 
            // ViborKorpusa
            // 
            this.ViborKorpusa.FormattingEnabled = true;
            this.ViborKorpusa.Location = new System.Drawing.Point(22, 55);
            this.ViborKorpusa.Name = "ViborKorpusa";
            this.ViborKorpusa.Size = new System.Drawing.Size(121, 21);
            this.ViborKorpusa.TabIndex = 20;
            this.ViborKorpusa.SelectedIndexChanged += new System.EventHandler(this.ViborPlati_SelectedIndexChanged);
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(187, 13);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(33, 13);
            this.Цена.TabIndex = 19;
            this.Цена.Text = "Цена";
            // 
            // Модель
            // 
            this.Модель.AutoSize = true;
            this.Модель.Location = new System.Drawing.Point(21, 13);
            this.Модель.Name = "Модель";
            this.Модель.Size = new System.Drawing.Size(46, 13);
            this.Модель.TabIndex = 18;
            this.Модель.Text = "Модель";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.Kartinka);
            this.Controls.Add(this.Opisanie);
            this.Controls.Add(this.Описание);
            this.Controls.Add(this.Artical);
            this.Controls.Add(this.Артикул);
            this.Controls.Add(this.VivodCeni);
            this.Controls.Add(this.ViborKorpusa);
            this.Controls.Add(this.Цена);
            this.Controls.Add(this.Модель);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form2";
            this.Text = "Выбор корпуса";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kartinka;
        private System.Windows.Forms.Label Opisanie;
        private System.Windows.Forms.Label Описание;
        private System.Windows.Forms.Label Artical;
        private System.Windows.Forms.Label Артикул;
        private System.Windows.Forms.Label VivodCeni;
        private System.Windows.Forms.ComboBox ViborKorpusa;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.Label Модель;
    }
}