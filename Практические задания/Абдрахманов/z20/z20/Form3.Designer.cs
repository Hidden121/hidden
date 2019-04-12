namespace z20
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
            this.Ishtext = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Bolshiebykvi = new System.Windows.Forms.Button();
            this.Smoollllllll = new System.Windows.Forms.Button();
            this.Bolshbykvi = new System.Windows.Forms.Label();
            this.Malenkie = new System.Windows.Forms.Label();
            this.Pohnali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ishtext
            // 
            this.Ishtext.AutoSize = true;
            this.Ishtext.Location = new System.Drawing.Point(12, 19);
            this.Ishtext.Name = "Ishtext";
            this.Ishtext.Size = new System.Drawing.Size(89, 13);
            this.Ishtext.TabIndex = 0;
            this.Ishtext.Text = "Исходный текст";
            this.Ishtext.Click += new System.EventHandler(this.Ishtext_Click);
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(135, 19);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 1;
            // 
            // Bolshiebykvi
            // 
            this.Bolshiebykvi.Location = new System.Drawing.Point(12, 52);
            this.Bolshiebykvi.Name = "Bolshiebykvi";
            this.Bolshiebykvi.Size = new System.Drawing.Size(127, 23);
            this.Bolshiebykvi.TabIndex = 2;
            this.Bolshiebykvi.Text = "Большими буквами";
            this.Bolshiebykvi.UseVisualStyleBackColor = true;
            this.Bolshiebykvi.Click += new System.EventHandler(this.Bolshiebykvi_Click);
            // 
            // Smoollllllll
            // 
            this.Smoollllllll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Smoollllllll.Location = new System.Drawing.Point(12, 95);
            this.Smoollllllll.Name = "Smoollllllll";
            this.Smoollllllll.Size = new System.Drawing.Size(127, 23);
            this.Smoollllllll.TabIndex = 3;
            this.Smoollllllll.Text = "Маленькими буквами";
            this.Smoollllllll.UseVisualStyleBackColor = true;
            this.Smoollllllll.Click += new System.EventHandler(this.Smoollllllll_Click);
            // 
            // Bolshbykvi
            // 
            this.Bolshbykvi.Location = new System.Drawing.Point(159, 52);
            this.Bolshbykvi.Name = "Bolshbykvi";
            this.Bolshbykvi.Size = new System.Drawing.Size(100, 23);
            this.Bolshbykvi.TabIndex = 4;
            // 
            // Malenkie
            // 
            this.Malenkie.Location = new System.Drawing.Point(159, 100);
            this.Malenkie.Name = "Malenkie";
            this.Malenkie.Size = new System.Drawing.Size(100, 18);
            this.Malenkie.TabIndex = 5;
            // 
            // Pohnali
            // 
            this.Pohnali.Location = new System.Drawing.Point(15, 139);
            this.Pohnali.Name = "Pohnali";
            this.Pohnali.Size = new System.Drawing.Size(75, 23);
            this.Pohnali.TabIndex = 6;
            this.Pohnali.Text = "Далее";
            this.Pohnali.UseVisualStyleBackColor = true;
            this.Pohnali.Click += new System.EventHandler(this.Pohnali_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 174);
            this.Controls.Add(this.Pohnali);
            this.Controls.Add(this.Malenkie);
            this.Controls.Add(this.Bolshbykvi);
            this.Controls.Add(this.Smoollllllll);
            this.Controls.Add(this.Bolshiebykvi);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Ishtext);
            this.MaximumSize = new System.Drawing.Size(325, 213);
            this.MinimumSize = new System.Drawing.Size(325, 213);
            this.Name = "Form3";
            this.Text = "Изменение регистра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ishtext;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Button Bolshiebykvi;
        private System.Windows.Forms.Button Smoollllllll;
        private System.Windows.Forms.Label Bolshbykvi;
        private System.Windows.Forms.Label Malenkie;
        private System.Windows.Forms.Button Pohnali;
    }
}