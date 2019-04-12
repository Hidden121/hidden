namespace z16
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
            this.Ras4itat = new System.Windows.Forms.Button();
            this.Okno = new System.Windows.Forms.ListBox();
            this.Chifri = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Chislo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ras4itat
            // 
            this.Ras4itat.Location = new System.Drawing.Point(16, 100);
            this.Ras4itat.Name = "Ras4itat";
            this.Ras4itat.Size = new System.Drawing.Size(75, 23);
            this.Ras4itat.TabIndex = 10;
            this.Ras4itat.Text = "Вывести";
            this.Ras4itat.UseVisualStyleBackColor = true;
            this.Ras4itat.Click += new System.EventHandler(this.Ras4itat_Click);
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Location = new System.Drawing.Point(152, 39);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(120, 108);
            this.Okno.TabIndex = 9;
            // 
            // Chifri
            // 
            this.Chifri.AutoSize = true;
            this.Chifri.Location = new System.Drawing.Point(170, 14);
            this.Chifri.Name = "Chifri";
            this.Chifri.Size = new System.Drawing.Size(89, 13);
            this.Chifri.TabIndex = 8;
            this.Chifri.Text = "Делители числа";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(16, 39);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 7;
            // 
            // Chislo
            // 
            this.Chislo.AutoSize = true;
            this.Chislo.Location = new System.Drawing.Point(13, 14);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(39, 13);
            this.Chislo.TabIndex = 6;
            this.Chislo.Text = "Число";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 176);
            this.Controls.Add(this.Ras4itat);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.Chifri);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Chislo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ras4itat;
        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.Label Chifri;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Label Chislo;
    }
}