namespace z11
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Pol = new System.Windows.Forms.Label();
            this.Rost = new System.Windows.Forms.Label();
            this.Ves = new System.Windows.Forms.Label();
            this.Mujskoi = new System.Windows.Forms.RadioButton();
            this.Jenski = new System.Windows.Forms.RadioButton();
            this.Vvodrosta = new System.Windows.Forms.TextBox();
            this.Vvodves = new System.Windows.Forms.TextBox();
            this.Ras4itat = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pol
            // 
            this.Pol.AutoSize = true;
            this.Pol.Location = new System.Drawing.Point(13, 13);
            this.Pol.Name = "Pol";
            this.Pol.Size = new System.Drawing.Size(49, 13);
            this.Pol.TabIndex = 0;
            this.Pol.Text = "Ваш пол";
            // 
            // Rost
            // 
            this.Rost.AutoSize = true;
            this.Rost.Location = new System.Drawing.Point(13, 80);
            this.Rost.Name = "Rost";
            this.Rost.Size = new System.Drawing.Size(77, 13);
            this.Rost.TabIndex = 1;
            this.Rost.Text = "Ваш рост (см)";
            // 
            // Ves
            // 
            this.Ves.AutoSize = true;
            this.Ves.Location = new System.Drawing.Point(13, 123);
            this.Ves.Name = "Ves";
            this.Ves.Size = new System.Drawing.Size(69, 13);
            this.Ves.TabIndex = 2;
            this.Ves.Text = "Ваш вес (кг)";
            // 
            // Mujskoi
            // 
            this.Mujskoi.AutoSize = true;
            this.Mujskoi.Location = new System.Drawing.Point(121, 13);
            this.Mujskoi.Name = "Mujskoi";
            this.Mujskoi.Size = new System.Drawing.Size(71, 17);
            this.Mujskoi.TabIndex = 3;
            this.Mujskoi.TabStop = true;
            this.Mujskoi.Text = "Мужской";
            this.Mujskoi.UseVisualStyleBackColor = true;
            // 
            // Jenski
            // 
            this.Jenski.AutoSize = true;
            this.Jenski.Location = new System.Drawing.Point(121, 49);
            this.Jenski.Name = "Jenski";
            this.Jenski.Size = new System.Drawing.Size(72, 17);
            this.Jenski.TabIndex = 4;
            this.Jenski.TabStop = true;
            this.Jenski.Text = "Женский";
            this.Jenski.UseVisualStyleBackColor = true;
            // 
            // Vvodrosta
            // 
            this.Vvodrosta.Location = new System.Drawing.Point(121, 80);
            this.Vvodrosta.Name = "Vvodrosta";
            this.Vvodrosta.Size = new System.Drawing.Size(82, 20);
            this.Vvodrosta.TabIndex = 5;
            // 
            // Vvodves
            // 
            this.Vvodves.Location = new System.Drawing.Point(121, 123);
            this.Vvodves.Name = "Vvodves";
            this.Vvodves.Size = new System.Drawing.Size(82, 20);
            this.Vvodves.TabIndex = 6;
            // 
            // Ras4itat
            // 
            this.Ras4itat.Location = new System.Drawing.Point(12, 167);
            this.Ras4itat.Name = "Ras4itat";
            this.Ras4itat.Size = new System.Drawing.Size(191, 23);
            this.Ras4itat.TabIndex = 7;
            this.Ras4itat.Text = "Рассчитать";
            this.Ras4itat.UseVisualStyleBackColor = true;
            this.Ras4itat.Click += new System.EventHandler(this.Ras4itat_Click);
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(227, 11);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(100, 179);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 8;
            this.Photo.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 204);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Ras4itat);
            this.Controls.Add(this.Vvodves);
            this.Controls.Add(this.Vvodrosta);
            this.Controls.Add(this.Jenski);
            this.Controls.Add(this.Mujskoi);
            this.Controls.Add(this.Ves);
            this.Controls.Add(this.Rost);
            this.Controls.Add(this.Pol);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pol;
        private System.Windows.Forms.Label Rost;
        private System.Windows.Forms.Label Ves;
        private System.Windows.Forms.RadioButton Mujskoi;
        private System.Windows.Forms.RadioButton Jenski;
        private System.Windows.Forms.TextBox Vvodrosta;
        private System.Windows.Forms.TextBox Vvodves;
        private System.Windows.Forms.Button Ras4itat;
        private System.Windows.Forms.PictureBox Photo;
    }
}