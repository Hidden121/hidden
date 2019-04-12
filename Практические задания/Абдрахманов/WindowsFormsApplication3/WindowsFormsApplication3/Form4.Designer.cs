namespace WindowsFormsApplication3
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
            this.Ves = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.Label();
            this.Oknoresultata = new System.Windows.Forms.Label();
            this.Vvodtexta = new System.Windows.Forms.TextBox();
            this.Funti = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ves
            // 
            this.Ves.AutoSize = true;
            this.Ves.Location = new System.Drawing.Point(38, 25);
            this.Ves.Name = "Ves";
            this.Ves.Size = new System.Drawing.Size(46, 13);
            this.Ves.TabIndex = 0;
            this.Ves.Text = "Вес (кг)";
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(164, 25);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(59, 13);
            this.Resultat.TabIndex = 1;
            this.Resultat.Text = "Результат";
            // 
            // Oknoresultata
            // 
            this.Oknoresultata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oknoresultata.Location = new System.Drawing.Point(167, 62);
            this.Oknoresultata.Name = "Oknoresultata";
            this.Oknoresultata.Size = new System.Drawing.Size(100, 23);
            this.Oknoresultata.TabIndex = 2;
            // 
            // Vvodtexta
            // 
            this.Vvodtexta.Location = new System.Drawing.Point(41, 62);
            this.Vvodtexta.Name = "Vvodtexta";
            this.Vvodtexta.Size = new System.Drawing.Size(100, 20);
            this.Vvodtexta.TabIndex = 3;
            // 
            // Funti
            // 
            this.Funti.Location = new System.Drawing.Point(41, 140);
            this.Funti.Name = "Funti";
            this.Funti.Size = new System.Drawing.Size(75, 23);
            this.Funti.TabIndex = 4;
            this.Funti.Text = "Фунтов";
            this.Funti.UseVisualStyleBackColor = true;
            this.Funti.Click += new System.EventHandler(this.Funti_Click);
            // 
            // Nazad
            // 
            this.Nazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nazad.BackgroundImage")));
            this.Nazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nazad.Location = new System.Drawing.Point(211, 140);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(56, 23);
            this.Nazad.TabIndex = 23;
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Funti);
            this.Controls.Add(this.Vvodtexta);
            this.Controls.Add(this.Oknoresultata);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Ves);
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мера веса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ves;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.Label Oknoresultata;
        private System.Windows.Forms.TextBox Vvodtexta;
        private System.Windows.Forms.Button Funti;
        private System.Windows.Forms.Button Nazad;
    }
}