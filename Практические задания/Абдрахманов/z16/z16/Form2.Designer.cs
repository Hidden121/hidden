namespace z16
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
            this.Ot = new System.Windows.Forms.Label();
            this.Do = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Vvod2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Okno = new System.Windows.Forms.ListBox();
            this.Delmost2 = new System.Windows.Forms.Button();
            this.Delmost3 = new System.Windows.Forms.Button();
            this.Delmost5 = new System.Windows.Forms.Button();
            this.Dalee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ot
            // 
            this.Ot.AutoSize = true;
            this.Ot.Location = new System.Drawing.Point(13, 13);
            this.Ot.Name = "Ot";
            this.Ot.Size = new System.Drawing.Size(20, 13);
            this.Ot.TabIndex = 0;
            this.Ot.Text = "От";
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(13, 51);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(22, 13);
            this.Do.TabIndex = 1;
            this.Do.Text = "До";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(55, 6);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 2;
            // 
            // Vvod2
            // 
            this.Vvod2.Location = new System.Drawing.Point(55, 44);
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Size = new System.Drawing.Size(100, 20);
            this.Vvod2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Делимость  на";
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Location = new System.Drawing.Point(161, 6);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(120, 134);
            this.Okno.TabIndex = 5;
            // 
            // Delmost2
            // 
            this.Delmost2.Location = new System.Drawing.Point(16, 96);
            this.Delmost2.Name = "Delmost2";
            this.Delmost2.Size = new System.Drawing.Size(36, 23);
            this.Delmost2.TabIndex = 6;
            this.Delmost2.Text = "2";
            this.Delmost2.UseVisualStyleBackColor = true;
            this.Delmost2.Click += new System.EventHandler(this.Delmost2_Click);
            // 
            // Delmost3
            // 
            this.Delmost3.Location = new System.Drawing.Point(55, 96);
            this.Delmost3.Name = "Delmost3";
            this.Delmost3.Size = new System.Drawing.Size(33, 23);
            this.Delmost3.TabIndex = 7;
            this.Delmost3.Text = "3";
            this.Delmost3.UseVisualStyleBackColor = true;
            this.Delmost3.Click += new System.EventHandler(this.Delmost3_Click);
            // 
            // Delmost5
            // 
            this.Delmost5.Location = new System.Drawing.Point(94, 96);
            this.Delmost5.Name = "Delmost5";
            this.Delmost5.Size = new System.Drawing.Size(35, 23);
            this.Delmost5.TabIndex = 8;
            this.Delmost5.Text = "5";
            this.Delmost5.UseVisualStyleBackColor = true;
            this.Delmost5.Click += new System.EventHandler(this.Delmost5_Click);
            // 
            // Dalee
            // 
            this.Dalee.Location = new System.Drawing.Point(16, 125);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(75, 23);
            this.Dalee.TabIndex = 9;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.Dalee_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.Delmost5);
            this.Controls.Add(this.Delmost3);
            this.Controls.Add(this.Delmost2);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vvod2);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.Ot);
            this.Name = "Form2";
            this.Text = "Делимость";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ot;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.TextBox Vvod2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.Button Delmost2;
        private System.Windows.Forms.Button Delmost3;
        private System.Windows.Forms.Button Delmost5;
        private System.Windows.Forms.Button Dalee;
    }
}