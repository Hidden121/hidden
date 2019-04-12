namespace WindowsFormsApplication2
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
            this.Vipolnit = new System.Windows.Forms.Button();
            this.Inform = new System.Windows.Forms.TextBox();
            this.Vvod4isla3 = new System.Windows.Forms.TextBox();
            this.Vvod4isla2 = new System.Windows.Forms.TextBox();
            this.Vvod4isla = new System.Windows.Forms.TextBox();
            this.Resultatviplpo = new System.Windows.Forms.Label();
            this.Zna4enie3 = new System.Windows.Forms.Label();
            this.Zna4enie2 = new System.Windows.Forms.Label();
            this.Zna4enie1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vipolnit
            // 
            this.Vipolnit.Location = new System.Drawing.Point(186, 227);
            this.Vipolnit.Name = "Vipolnit";
            this.Vipolnit.Size = new System.Drawing.Size(75, 23);
            this.Vipolnit.TabIndex = 18;
            this.Vipolnit.Text = "Выполнить";
            this.Vipolnit.UseVisualStyleBackColor = true;
            this.Vipolnit.Click += new System.EventHandler(this.Vipolnit_Click);
            // 
            // Inform
            // 
            this.Inform.Location = new System.Drawing.Point(27, 125);
            this.Inform.Multiline = true;
            this.Inform.Name = "Inform";
            this.Inform.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Inform.Size = new System.Drawing.Size(234, 96);
            this.Inform.TabIndex = 17;
            // 
            // Vvod4isla3
            // 
            this.Vvod4isla3.Location = new System.Drawing.Point(142, 76);
            this.Vvod4isla3.Name = "Vvod4isla3";
            this.Vvod4isla3.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla3.TabIndex = 16;
            // 
            // Vvod4isla2
            // 
            this.Vvod4isla2.Location = new System.Drawing.Point(142, 42);
            this.Vvod4isla2.Name = "Vvod4isla2";
            this.Vvod4isla2.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla2.TabIndex = 15;
            // 
            // Vvod4isla
            // 
            this.Vvod4isla.Location = new System.Drawing.Point(142, 11);
            this.Vvod4isla.Name = "Vvod4isla";
            this.Vvod4isla.Size = new System.Drawing.Size(119, 20);
            this.Vvod4isla.TabIndex = 14;
            // 
            // Resultatviplpo
            // 
            this.Resultatviplpo.AutoSize = true;
            this.Resultatviplpo.Location = new System.Drawing.Point(24, 109);
            this.Resultatviplpo.Name = "Resultatviplpo";
            this.Resultatviplpo.Size = new System.Drawing.Size(191, 13);
            this.Resultatviplpo.TabIndex = 13;
            this.Resultatviplpo.Text = "Результаты выолнения программы:";
            // 
            // Zna4enie3
            // 
            this.Zna4enie3.AutoSize = true;
            this.Zna4enie3.Location = new System.Drawing.Point(24, 76);
            this.Zna4enie3.Name = "Zna4enie3";
            this.Zna4enie3.Size = new System.Drawing.Size(112, 13);
            this.Zna4enie3.TabIndex = 12;
            this.Zna4enie3.Text = "Введите значение Z:";
            // 
            // Zna4enie2
            // 
            this.Zna4enie2.AutoSize = true;
            this.Zna4enie2.Location = new System.Drawing.Point(24, 45);
            this.Zna4enie2.Name = "Zna4enie2";
            this.Zna4enie2.Size = new System.Drawing.Size(112, 13);
            this.Zna4enie2.TabIndex = 11;
            this.Zna4enie2.Text = "Введите значение Y:";
            // 
            // Zna4enie1
            // 
            this.Zna4enie1.AutoSize = true;
            this.Zna4enie1.Location = new System.Drawing.Point(24, 14);
            this.Zna4enie1.Name = "Zna4enie1";
            this.Zna4enie1.Size = new System.Drawing.Size(112, 13);
            this.Zna4enie1.TabIndex = 10;
            this.Zna4enie1.Text = "Введите значение Х:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Vipolnit);
            this.Controls.Add(this.Inform);
            this.Controls.Add(this.Vvod4isla3);
            this.Controls.Add(this.Vvod4isla2);
            this.Controls.Add(this.Vvod4isla);
            this.Controls.Add(this.Resultatviplpo);
            this.Controls.Add(this.Zna4enie3);
            this.Controls.Add(this.Zna4enie2);
            this.Controls.Add(this.Zna4enie1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vipolnit;
        private System.Windows.Forms.TextBox Inform;
        private System.Windows.Forms.TextBox Vvod4isla3;
        private System.Windows.Forms.TextBox Vvod4isla2;
        private System.Windows.Forms.TextBox Vvod4isla;
        private System.Windows.Forms.Label Resultatviplpo;
        private System.Windows.Forms.Label Zna4enie3;
        private System.Windows.Forms.Label Zna4enie2;
        private System.Windows.Forms.Label Zna4enie1;
    }
}