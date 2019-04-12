namespace WindowsFormsApplication3
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
            this.Cheslo = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.Label();
            this.Vvod4isla = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Nazad = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Obnulenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cheslo
            // 
            this.Cheslo.AutoSize = true;
            this.Cheslo.Location = new System.Drawing.Point(40, 31);
            this.Cheslo.Name = "Cheslo";
            this.Cheslo.Size = new System.Drawing.Size(39, 13);
            this.Cheslo.TabIndex = 0;
            this.Cheslo.Text = "Число";
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(177, 31);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(59, 13);
            this.Resultat.TabIndex = 1;
            this.Resultat.Text = "Результат";
            // 
            // Vvod4isla
            // 
            this.Vvod4isla.Location = new System.Drawing.Point(23, 55);
            this.Vvod4isla.Name = "Vvod4isla";
            this.Vvod4isla.Size = new System.Drawing.Size(100, 20);
            this.Vvod4isla.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Location = new System.Drawing.Point(161, 55);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 23);
            this.Result.TabIndex = 3;
            // 
            // Nazad
            // 
            this.Nazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nazad.BackgroundImage")));
            this.Nazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nazad.Location = new System.Drawing.Point(205, 134);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(56, 23);
            this.Nazad.TabIndex = 22;
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(23, 191);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 24;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(124, 191);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 25;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(205, 191);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 26;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Obnulenia
            // 
            this.Obnulenia.Location = new System.Drawing.Point(23, 127);
            this.Obnulenia.Name = "Obnulenia";
            this.Obnulenia.Size = new System.Drawing.Size(56, 30);
            this.Obnulenia.TabIndex = 27;
            this.Obnulenia.Text = "С";
            this.Obnulenia.UseVisualStyleBackColor = true;
            this.Obnulenia.Click += new System.EventHandler(this.Obnulenia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.Obnulenia);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Vvod4isla);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Cheslo);
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Функции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cheslo;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.TextBox Vvod4isla;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Obnulenia;
    }
}