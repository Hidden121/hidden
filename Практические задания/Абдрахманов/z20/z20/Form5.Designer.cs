namespace z20
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
            this.label1 = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Smena = new System.Windows.Forms.Label();
            this.Na4to = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.Label();
            this.Otvet = new System.Windows.Forms.Label();
            this.Zamena = new System.Windows.Forms.Button();
            this.Vvod3 = new System.Windows.Forms.TextBox();
            this.Vvod2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "исходный текст";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(106, 12);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(188, 20);
            this.Vvod.TabIndex = 1;
            // 
            // Smena
            // 
            this.Smena.AutoSize = true;
            this.Smena.Location = new System.Drawing.Point(16, 59);
            this.Smena.Name = "Smena";
            this.Smena.Size = new System.Drawing.Size(69, 13);
            this.Smena.TabIndex = 2;
            this.Smena.Text = "Что меняем";
            // 
            // Na4to
            // 
            this.Na4to.AutoSize = true;
            this.Na4to.Location = new System.Drawing.Point(16, 99);
            this.Na4to.Name = "Na4to";
            this.Na4to.Size = new System.Drawing.Size(83, 13);
            this.Na4to.TabIndex = 3;
            this.Na4to.Text = "На что меняем";
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(20, 186);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(59, 13);
            this.Resultat.TabIndex = 4;
            this.Resultat.Text = "Результат";
            // 
            // Otvet
            // 
            this.Otvet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Otvet.Location = new System.Drawing.Point(106, 186);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(188, 23);
            this.Otvet.TabIndex = 5;
            // 
            // Zamena
            // 
            this.Zamena.Location = new System.Drawing.Point(16, 143);
            this.Zamena.Name = "Zamena";
            this.Zamena.Size = new System.Drawing.Size(278, 23);
            this.Zamena.TabIndex = 6;
            this.Zamena.Text = "Замена";
            this.Zamena.UseVisualStyleBackColor = true;
            this.Zamena.Click += new System.EventHandler(this.Zamena_Click);
            // 
            // Vvod3
            // 
            this.Vvod3.Location = new System.Drawing.Point(106, 99);
            this.Vvod3.Name = "Vvod3";
            this.Vvod3.Size = new System.Drawing.Size(188, 20);
            this.Vvod3.TabIndex = 7;
            // 
            // Vvod2
            // 
            this.Vvod2.Location = new System.Drawing.Point(106, 59);
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Size = new System.Drawing.Size(188, 20);
            this.Vvod2.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(319, 225);
            this.Controls.Add(this.Vvod2);
            this.Controls.Add(this.Vvod3);
            this.Controls.Add(this.Zamena);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Na4to);
            this.Controls.Add(this.Smena);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Замена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Label Smena;
        private System.Windows.Forms.Label Na4to;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.Label Otvet;
        private System.Windows.Forms.Button Zamena;
        private System.Windows.Forms.TextBox Vvod3;
        private System.Windows.Forms.TextBox Vvod2;
    }
}