namespace z7
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Aftor = new System.Windows.Forms.Label();
            this.VvodTexta = new System.Windows.Forms.Label();
            this.Naim = new System.Windows.Forms.Label();
            this.Naimenovanie = new System.Windows.Forms.Label();
            this.Chena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Knopka = new System.Windows.Forms.Button();
            this.Knopka2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(23, 154);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(231, 95);
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // Aftor
            // 
            this.Aftor.AutoSize = true;
            this.Aftor.Location = new System.Drawing.Point(52, 9);
            this.Aftor.Name = "Aftor";
            this.Aftor.Size = new System.Drawing.Size(37, 13);
            this.Aftor.TabIndex = 1;
            this.Aftor.Text = "Автор";
            // 
            // VvodTexta
            // 
            this.VvodTexta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VvodTexta.Location = new System.Drawing.Point(12, 43);
            this.VvodTexta.Name = "VvodTexta";
            this.VvodTexta.Size = new System.Drawing.Size(125, 23);
            this.VvodTexta.TabIndex = 2;
            // 
            // Naim
            // 
            this.Naim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Naim.Location = new System.Drawing.Point(154, 43);
            this.Naim.Name = "Naim";
            this.Naim.Size = new System.Drawing.Size(118, 23);
            this.Naim.TabIndex = 4;
            // 
            // Naimenovanie
            // 
            this.Naimenovanie.AutoSize = true;
            this.Naimenovanie.Location = new System.Drawing.Point(171, 9);
            this.Naimenovanie.Name = "Naimenovanie";
            this.Naimenovanie.Size = new System.Drawing.Size(83, 13);
            this.Naimenovanie.TabIndex = 3;
            this.Naimenovanie.Text = "Наименование";
            // 
            // Chena
            // 
            this.Chena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Chena.Location = new System.Drawing.Point(23, 114);
            this.Chena.Name = "Chena";
            this.Chena.Size = new System.Drawing.Size(100, 23);
            this.Chena.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // Knopka
            // 
            this.Knopka.AutoEllipsis = true;
            this.Knopka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Knopka.BackgroundImage")));
            this.Knopka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Knopka.Location = new System.Drawing.Point(145, 100);
            this.Knopka.Name = "Knopka";
            this.Knopka.Size = new System.Drawing.Size(46, 37);
            this.Knopka.TabIndex = 7;
            this.Knopka.UseVisualStyleBackColor = true;
            this.Knopka.Click += new System.EventHandler(this.Knopka_Click);
            // 
            // Knopka2
            // 
            this.Knopka2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Knopka2.BackgroundImage")));
            this.Knopka2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Knopka2.Location = new System.Drawing.Point(207, 100);
            this.Knopka2.Name = "Knopka2";
            this.Knopka2.Size = new System.Drawing.Size(47, 37);
            this.Knopka2.TabIndex = 8;
            this.Knopka2.UseVisualStyleBackColor = true;
            this.Knopka2.Click += new System.EventHandler(this.Knopka2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 274);
            this.Controls.Add(this.Knopka2);
            this.Controls.Add(this.Knopka);
            this.Controls.Add(this.Chena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Naim);
            this.Controls.Add(this.Naimenovanie);
            this.Controls.Add(this.VvodTexta);
            this.Controls.Add(this.Aftor);
            this.Controls.Add(this.Photo);
            this.MaximumSize = new System.Drawing.Size(307, 313);
            this.MinimumSize = new System.Drawing.Size(307, 313);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Галерея";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Label Aftor;
        private System.Windows.Forms.Label VvodTexta;
        private System.Windows.Forms.Label Naim;
        private System.Windows.Forms.Label Naimenovanie;
        private System.Windows.Forms.Label Chena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Knopka;
        private System.Windows.Forms.Button Knopka2;
    }
}