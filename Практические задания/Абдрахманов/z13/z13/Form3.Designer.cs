namespace z13
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
            this.OK = new System.Windows.Forms.Button();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Vvod2 = new System.Windows.Forms.TextBox();
            this.Ot = new System.Windows.Forms.Label();
            this.Do = new System.Windows.Forms.Label();
            this.Okno = new System.Windows.Forms.ListBox();
            this.Otvet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 129);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(44, 9);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(70, 20);
            this.Vvod.TabIndex = 1;
            // 
            // Vvod2
            // 
            this.Vvod2.Location = new System.Drawing.Point(44, 50);
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Size = new System.Drawing.Size(70, 20);
            this.Vvod2.TabIndex = 2;
            // 
            // Ot
            // 
            this.Ot.AutoSize = true;
            this.Ot.Location = new System.Drawing.Point(13, 12);
            this.Ot.Name = "Ot";
            this.Ot.Size = new System.Drawing.Size(20, 13);
            this.Ot.TabIndex = 3;
            this.Ot.Text = "От";
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(16, 57);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(22, 13);
            this.Do.TabIndex = 4;
            this.Do.Text = "До";
            // 
            // Okno
            // 
            this.Okno.FormattingEnabled = true;
            this.Okno.Location = new System.Drawing.Point(143, 12);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(120, 95);
            this.Okno.TabIndex = 5;
            // 
            // Otvet
            // 
            this.Otvet.AutoSize = true;
            this.Otvet.Location = new System.Drawing.Point(16, 101);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(37, 13);
            this.Otvet.TabIndex = 6;
            this.Otvet.Text = "Ответ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(286, 261);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Vvod2);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.OK);
            this.Name = "Form3";
            this.Text = "количества отрицательных случайных чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.TextBox Vvod2;
        private System.Windows.Forms.Label Ot;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.ListBox Okno;
        private System.Windows.Forms.Label Otvet;
    }
}