namespace z12
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
            this.Nod = new System.Windows.Forms.Button();
            this.Vivod = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Poehalidalshie = new System.Windows.Forms.Button();
            this.Vvod2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nod
            // 
            this.Nod.Location = new System.Drawing.Point(27, 87);
            this.Nod.Name = "Nod";
            this.Nod.Size = new System.Drawing.Size(75, 23);
            this.Nod.TabIndex = 0;
            this.Nod.Text = "НОД";
            this.Nod.UseVisualStyleBackColor = true;
            this.Nod.Click += new System.EventHandler(this.Nod_Click);
            // 
            // Vivod
            // 
            this.Vivod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Vivod.Location = new System.Drawing.Point(152, 20);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(100, 20);
            this.Vivod.TabIndex = 1;
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(27, 20);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 2;
            // 
            // Poehalidalshie
            // 
            this.Poehalidalshie.Location = new System.Drawing.Point(164, 87);
            this.Poehalidalshie.Name = "Poehalidalshie";
            this.Poehalidalshie.Size = new System.Drawing.Size(75, 23);
            this.Poehalidalshie.TabIndex = 3;
            this.Poehalidalshie.Text = "Далее";
            this.Poehalidalshie.UseVisualStyleBackColor = true;
            this.Poehalidalshie.Click += new System.EventHandler(this.Poehalidalshie_Click);
            // 
            // Vvod2
            // 
            this.Vvod2.Location = new System.Drawing.Point(27, 61);
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Size = new System.Drawing.Size(100, 20);
            this.Vvod2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 134);
            this.Controls.Add(this.Vvod2);
            this.Controls.Add(this.Poehalidalshie);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Nod);
            this.Name = "Form2";
            this.Text = "Вычисление наибольшего общего делителя ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nod;
        private System.Windows.Forms.Label Vivod;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Button Poehalidalshie;
        private System.Windows.Forms.TextBox Vvod2;
    }
}