namespace z13
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
            this.Okno = new System.Windows.Forms.ListBox();
            this.Okno2 = new System.Windows.Forms.ListBox();
            this.Ot = new System.Windows.Forms.Label();
            this.Do = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Vvod2 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Perehod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Location = new System.Drawing.Point(13, 13);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(68, 186);
            this.Okno.TabIndex = 0;
            // 
            // Okno2
            // 
            this.Okno2.FormattingEnabled = true;
            this.Okno2.Location = new System.Drawing.Point(97, 13);
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(73, 186);
            this.Okno2.TabIndex = 1;
            // 
            // Ot
            // 
            this.Ot.AutoSize = true;
            this.Ot.Location = new System.Drawing.Point(186, 13);
            this.Ot.Name = "Ot";
            this.Ot.Size = new System.Drawing.Size(18, 13);
            this.Ot.TabIndex = 2;
            this.Ot.Text = "от";
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(186, 45);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(19, 13);
            this.Do.TabIndex = 3;
            this.Do.Text = "до";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(210, 13);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(72, 20);
            this.Vvod.TabIndex = 4;
            // 
            // Vvod2
            // 
            this.Vvod2.Location = new System.Drawing.Point(212, 45);
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Size = new System.Drawing.Size(70, 20);
            this.Vvod2.TabIndex = 5;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(189, 97);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(189, 138);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 7;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Vvod2);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Okno);
            this.Name = "Form2";
            this.Text = "Квадраты чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.ListBox Okno2;
        private System.Windows.Forms.Label Ot;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.TextBox Vvod2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Perehod;
    }
}