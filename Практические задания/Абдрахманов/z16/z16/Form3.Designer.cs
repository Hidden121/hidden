namespace z16
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
            this.Chislo = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Chifri = new System.Windows.Forms.Label();
            this.Okno = new System.Windows.Forms.ListBox();
            this.Ras4itat = new System.Windows.Forms.Button();
            this.Dalee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chislo
            // 
            this.Chislo.AutoSize = true;
            this.Chislo.Location = new System.Drawing.Point(13, 13);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(39, 13);
            this.Chislo.TabIndex = 0;
            this.Chislo.Text = "Число";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(16, 38);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 1;
            // 
            // Chifri
            // 
            this.Chifri.AutoSize = true;
            this.Chifri.Location = new System.Drawing.Point(170, 13);
            this.Chifri.Name = "Chifri";
            this.Chifri.Size = new System.Drawing.Size(61, 13);
            this.Chifri.TabIndex = 2;
            this.Chifri.Text = "его цифры";
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Location = new System.Drawing.Point(152, 38);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(120, 95);
            this.Okno.TabIndex = 3;
            // 
            // Ras4itat
            // 
            this.Ras4itat.Location = new System.Drawing.Point(16, 75);
            this.Ras4itat.Name = "Ras4itat";
            this.Ras4itat.Size = new System.Drawing.Size(75, 23);
            this.Ras4itat.TabIndex = 4;
            this.Ras4itat.Text = "Рассчитать";
            this.Ras4itat.UseVisualStyleBackColor = true;
            this.Ras4itat.Click += new System.EventHandler(this.Ras4itat_Click);
            // 
            // Dalee
            // 
            this.Dalee.Location = new System.Drawing.Point(16, 109);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(75, 23);
            this.Dalee.TabIndex = 5;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.Dalee_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.Ras4itat);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.Chifri);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Chislo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chislo;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Label Chifri;
        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.Button Ras4itat;
        private System.Windows.Forms.Button Dalee;
    }
}