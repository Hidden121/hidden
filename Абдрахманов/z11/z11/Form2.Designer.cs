namespace z11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Vvodchisla = new System.Windows.Forms.TextBox();
            this.Vvod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Zadatchislo = new System.Windows.Forms.Button();
            this.Surrender = new System.Windows.Forms.Button();
            this.Dalee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vvodchisla
            // 
            this.Vvodchisla.Location = new System.Drawing.Point(25, 13);
            this.Vvodchisla.Name = "Vvodchisla";
            this.Vvodchisla.Size = new System.Drawing.Size(142, 20);
            this.Vvodchisla.TabIndex = 0;
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(185, 13);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 1;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Zadatchislo
            // 
            this.Zadatchislo.Location = new System.Drawing.Point(25, 53);
            this.Zadatchislo.Name = "Zadatchislo";
            this.Zadatchislo.Size = new System.Drawing.Size(235, 23);
            this.Zadatchislo.TabIndex = 3;
            this.Zadatchislo.Text = "Задать новое число";
            this.Zadatchislo.UseVisualStyleBackColor = true;
            this.Zadatchislo.Click += new System.EventHandler(this.Zadatchislo_Click);
            // 
            // Surrender
            // 
            this.Surrender.Location = new System.Drawing.Point(25, 82);
            this.Surrender.Name = "Surrender";
            this.Surrender.Size = new System.Drawing.Size(235, 23);
            this.Surrender.TabIndex = 4;
            this.Surrender.Text = "Сдаюсь";
            this.Surrender.UseVisualStyleBackColor = true;
            this.Surrender.Click += new System.EventHandler(this.Surrender_Click);
            // 
            // Dalee
            // 
            this.Dalee.Location = new System.Drawing.Point(25, 111);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(235, 31);
            this.Dalee.TabIndex = 5;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.Dalee_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 144);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.Surrender);
            this.Controls.Add(this.Zadatchislo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Vvodchisla);
            this.Name = "Form2";
            this.Text = "Игра\"Угадай число\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vvodchisla;
        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Zadatchislo;
        private System.Windows.Forms.Button Surrender;
        private System.Windows.Forms.Button Dalee;
    }
}