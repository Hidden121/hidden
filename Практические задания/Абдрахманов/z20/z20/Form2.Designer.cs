namespace z20
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
            this.Imea = new System.Windows.Forms.Label();
            this.Vvodimeni = new System.Windows.Forms.TextBox();
            this.Privetstvie = new System.Windows.Forms.Button();
            this.Vivod = new System.Windows.Forms.Label();
            this.Dalee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Imea
            // 
            this.Imea.AutoSize = true;
            this.Imea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Imea.Location = new System.Drawing.Point(13, 24);
            this.Imea.Name = "Imea";
            this.Imea.Size = new System.Drawing.Size(69, 16);
            this.Imea.TabIndex = 0;
            this.Imea.Text = "Ваше имя";
            // 
            // Vvodimeni
            // 
            this.Vvodimeni.Location = new System.Drawing.Point(89, 24);
            this.Vvodimeni.Name = "Vvodimeni";
            this.Vvodimeni.Size = new System.Drawing.Size(100, 20);
            this.Vvodimeni.TabIndex = 1;
            // 
            // Privetstvie
            // 
            this.Privetstvie.Location = new System.Drawing.Point(13, 66);
            this.Privetstvie.Name = "Privetstvie";
            this.Privetstvie.Size = new System.Drawing.Size(82, 23);
            this.Privetstvie.TabIndex = 2;
            this.Privetstvie.Text = "Приветствие";
            this.Privetstvie.UseVisualStyleBackColor = true;
            this.Privetstvie.Click += new System.EventHandler(this.Privetstvie_Click);
            // 
            // Vivod
            // 
            this.Vivod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Vivod.Location = new System.Drawing.Point(116, 66);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(156, 23);
            this.Vivod.TabIndex = 3;
            // 
            // Dalee
            // 
            this.Dalee.AutoSize = true;
            this.Dalee.Location = new System.Drawing.Point(206, 24);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(75, 23);
            this.Dalee.TabIndex = 4;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.Dalee_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Privetstvie);
            this.Controls.Add(this.Vvodimeni);
            this.Controls.Add(this.Imea);
            this.MaximumSize = new System.Drawing.Size(300, 153);
            this.MinimumSize = new System.Drawing.Size(300, 153);
            this.Name = "Form2";
            this.Text = "Знакомство";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imea;
        private System.Windows.Forms.TextBox Vvodimeni;
        private System.Windows.Forms.Button Privetstvie;
        private System.Windows.Forms.Label Vivod;
        private System.Windows.Forms.Button Dalee;
    }
}