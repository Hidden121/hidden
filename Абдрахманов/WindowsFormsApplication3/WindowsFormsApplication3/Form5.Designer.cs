namespace WindowsFormsApplication3
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.DlinaStoron = new System.Windows.Forms.Label();
            this.Ploshad = new System.Windows.Forms.Label();
            this.DlinaVisoti = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Vvodchisla = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Glavnai = new System.Windows.Forms.Button();
            this.Obnulenia = new System.Windows.Forms.Button();
            this.Treygolnik = new System.Windows.Forms.Button();
            this.Kvadrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DlinaStoron
            // 
            this.DlinaStoron.AutoSize = true;
            this.DlinaStoron.Location = new System.Drawing.Point(36, 31);
            this.DlinaStoron.Name = "DlinaStoron";
            this.DlinaStoron.Size = new System.Drawing.Size(86, 13);
            this.DlinaStoron.TabIndex = 0;
            this.DlinaStoron.Text = "Длина стороны";
            // 
            // Ploshad
            // 
            this.Ploshad.AutoSize = true;
            this.Ploshad.Location = new System.Drawing.Point(184, 31);
            this.Ploshad.Name = "Ploshad";
            this.Ploshad.Size = new System.Drawing.Size(54, 13);
            this.Ploshad.TabIndex = 1;
            this.Ploshad.Text = "Площадь";
            // 
            // DlinaVisoti
            // 
            this.DlinaVisoti.AutoSize = true;
            this.DlinaVisoti.Location = new System.Drawing.Point(36, 103);
            this.DlinaVisoti.Name = "DlinaVisoti";
            this.DlinaVisoti.Size = new System.Drawing.Size(82, 13);
            this.DlinaVisoti.TabIndex = 2;
            this.DlinaVisoti.Text = "Длина высоты";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(39, 60);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 3;
            // 
            // Vvodchisla
            // 
            this.Vvodchisla.Location = new System.Drawing.Point(39, 141);
            this.Vvodchisla.Name = "Vvodchisla";
            this.Vvodchisla.Size = new System.Drawing.Size(100, 20);
            this.Vvodchisla.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Location = new System.Drawing.Point(187, 57);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 23);
            this.Result.TabIndex = 5;
            // 
            // Glavnai
            // 
            this.Glavnai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Glavnai.BackgroundImage")));
            this.Glavnai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Glavnai.Location = new System.Drawing.Point(215, 191);
            this.Glavnai.Name = "Glavnai";
            this.Glavnai.Size = new System.Drawing.Size(56, 23);
            this.Glavnai.TabIndex = 22;
            this.Glavnai.UseVisualStyleBackColor = true;
            this.Glavnai.Click += new System.EventHandler(this.Glavnai_Click);
            // 
            // Obnulenia
            // 
            this.Obnulenia.Location = new System.Drawing.Point(215, 141);
            this.Obnulenia.Name = "Obnulenia";
            this.Obnulenia.Size = new System.Drawing.Size(56, 30);
            this.Obnulenia.TabIndex = 23;
            this.Obnulenia.Text = "С";
            this.Obnulenia.UseVisualStyleBackColor = true;
            this.Obnulenia.Click += new System.EventHandler(this.Obnulenia_Click);
            // 
            // Treygolnik
            // 
            this.Treygolnik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Treygolnik.BackgroundImage")));
            this.Treygolnik.Location = new System.Drawing.Point(39, 191);
            this.Treygolnik.Name = "Treygolnik";
            this.Treygolnik.Size = new System.Drawing.Size(71, 53);
            this.Treygolnik.TabIndex = 24;
            this.Treygolnik.UseVisualStyleBackColor = true;
            this.Treygolnik.Click += new System.EventHandler(this.Treygolnik_Click);
            // 
            // Kvadrat
            // 
            this.Kvadrat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kvadrat.BackgroundImage")));
            this.Kvadrat.Location = new System.Drawing.Point(116, 191);
            this.Kvadrat.Name = "Kvadrat";
            this.Kvadrat.Size = new System.Drawing.Size(77, 53);
            this.Kvadrat.TabIndex = 25;
            this.Kvadrat.UseVisualStyleBackColor = true;
            this.Kvadrat.Click += new System.EventHandler(this.Kvadrat_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Kvadrat);
            this.Controls.Add(this.Treygolnik);
            this.Controls.Add(this.Obnulenia);
            this.Controls.Add(this.Glavnai);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Vvodchisla);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.DlinaVisoti);
            this.Controls.Add(this.Ploshad);
            this.Controls.Add(this.DlinaStoron);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Площади фигур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DlinaStoron;
        private System.Windows.Forms.Label Ploshad;
        private System.Windows.Forms.Label DlinaVisoti;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.TextBox Vvodchisla;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Glavnai;
        private System.Windows.Forms.Button Obnulenia;
        private System.Windows.Forms.Button Treygolnik;
        private System.Windows.Forms.Button Kvadrat;
    }
}