namespace z12
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
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.Otvet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(23, 21);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(23, 68);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 23);
            this.Result.TabIndex = 1;
            this.Result.Text = "Resultat";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Otvet
            // 
            this.Otvet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Otvet.Location = new System.Drawing.Point(143, 21);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(100, 23);
            this.Otvet.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 119);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Vvod);
            this.Name = "Form3";
            this.Text = "Вычисление суммы цифр числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label Otvet;
    }
}