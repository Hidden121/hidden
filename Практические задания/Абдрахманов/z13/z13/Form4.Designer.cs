namespace z13
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
            this.Perehod = new System.Windows.Forms.Button();
            this.Otvet = new System.Windows.Forms.Label();
            this.Fibonachii = new System.Windows.Forms.Button();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(164, 58);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 7;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Otvet
            // 
            this.Otvet.Location = new System.Drawing.Point(137, 20);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(100, 23);
            this.Otvet.TabIndex = 6;
            // 
            // Fibonachii
            // 
            this.Fibonachii.Location = new System.Drawing.Point(15, 59);
            this.Fibonachii.Name = "Fibonachii";
            this.Fibonachii.Size = new System.Drawing.Size(123, 23);
            this.Fibonachii.TabIndex = 5;
            this.Fibonachii.Text = "Число Фибоначчи";
            this.Fibonachii.UseVisualStyleBackColor = true;
            this.Fibonachii.Click += new System.EventHandler(this.Fibonachii_Click);
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(15, 14);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Fibonachii);
            this.Controls.Add(this.Vvod);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.Label Otvet;
        private System.Windows.Forms.Button Fibonachii;
        private System.Windows.Forms.TextBox Vvod;
    }
}