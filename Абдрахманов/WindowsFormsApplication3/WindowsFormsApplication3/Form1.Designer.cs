namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Photo = new System.Windows.Forms.PictureBox();
            this.PloshadFigur = new System.Windows.Forms.Button();
            this.MeriVesa = new System.Windows.Forms.Button();
            this.MeriDlini = new System.Windows.Forms.Button();
            this.Funkci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(104, 20);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(186, 157);
            this.Photo.TabIndex = 9;
            this.Photo.TabStop = false;
            // 
            // PloshadFigur
            // 
            this.PloshadFigur.Location = new System.Drawing.Point(2, 154);
            this.PloshadFigur.Name = "PloshadFigur";
            this.PloshadFigur.Size = new System.Drawing.Size(96, 23);
            this.PloshadFigur.TabIndex = 8;
            this.PloshadFigur.Text = "Площади фигур";
            this.PloshadFigur.UseVisualStyleBackColor = true;
            this.PloshadFigur.Click += new System.EventHandler(this.PloshadFigur_Click);
            // 
            // MeriVesa
            // 
            this.MeriVesa.Location = new System.Drawing.Point(2, 111);
            this.MeriVesa.Name = "MeriVesa";
            this.MeriVesa.Size = new System.Drawing.Size(96, 23);
            this.MeriVesa.TabIndex = 7;
            this.MeriVesa.Text = "Меры веса";
            this.MeriVesa.UseVisualStyleBackColor = true;
            this.MeriVesa.Click += new System.EventHandler(this.MeriVesa_Click);
            // 
            // MeriDlini
            // 
            this.MeriDlini.Location = new System.Drawing.Point(2, 66);
            this.MeriDlini.Name = "MeriDlini";
            this.MeriDlini.Size = new System.Drawing.Size(96, 23);
            this.MeriDlini.TabIndex = 6;
            this.MeriDlini.Text = "Меры длины";
            this.MeriDlini.UseVisualStyleBackColor = true;
            this.MeriDlini.Click += new System.EventHandler(this.MeriDlini_Click);
            // 
            // Funkci
            // 
            this.Funkci.Location = new System.Drawing.Point(2, 20);
            this.Funkci.Name = "Funkci";
            this.Funkci.Size = new System.Drawing.Size(96, 23);
            this.Funkci.TabIndex = 5;
            this.Funkci.Text = "Функции";
            this.Funkci.UseVisualStyleBackColor = true;
            this.Funkci.Click += new System.EventHandler(this.Funkci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.PloshadFigur);
            this.Controls.Add(this.MeriVesa);
            this.Controls.Add(this.MeriDlini);
            this.Controls.Add(this.Funkci);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button PloshadFigur;
        private System.Windows.Forms.Button MeriVesa;
        private System.Windows.Forms.Button MeriDlini;
        private System.Windows.Forms.Button Funkci;
    }
}

