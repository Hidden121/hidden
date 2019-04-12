namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Dlina = new System.Windows.Forms.Label();
            this.Resultatinfa = new System.Windows.Forms.Label();
            this.Vvodtexta = new System.Windows.Forms.TextBox();
            this.Duim = new System.Windows.Forms.Button();
            this.Milia = new System.Windows.Forms.Button();
            this.Oknovivoda = new System.Windows.Forms.Label();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dlina
            // 
            this.Dlina.AutoSize = true;
            this.Dlina.Location = new System.Drawing.Point(33, 13);
            this.Dlina.Name = "Dlina";
            this.Dlina.Size = new System.Drawing.Size(57, 13);
            this.Dlina.TabIndex = 0;
            this.Dlina.Text = "Длина (м)";
            // 
            // Resultatinfa
            // 
            this.Resultatinfa.AutoSize = true;
            this.Resultatinfa.Location = new System.Drawing.Point(166, 13);
            this.Resultatinfa.Name = "Resultatinfa";
            this.Resultatinfa.Size = new System.Drawing.Size(59, 13);
            this.Resultatinfa.TabIndex = 1;
            this.Resultatinfa.Text = "Результат";
            // 
            // Vvodtexta
            // 
            this.Vvodtexta.Location = new System.Drawing.Point(36, 62);
            this.Vvodtexta.Name = "Vvodtexta";
            this.Vvodtexta.Size = new System.Drawing.Size(100, 20);
            this.Vvodtexta.TabIndex = 2;
            // 
            // Duim
            // 
            this.Duim.Location = new System.Drawing.Point(36, 146);
            this.Duim.Name = "Duim";
            this.Duim.Size = new System.Drawing.Size(75, 23);
            this.Duim.TabIndex = 3;
            this.Duim.Text = "дюйм";
            this.Duim.UseVisualStyleBackColor = true;
            this.Duim.Click += new System.EventHandler(this.Duim_Click);
            // 
            // Milia
            // 
            this.Milia.Location = new System.Drawing.Point(36, 200);
            this.Milia.Name = "Milia";
            this.Milia.Size = new System.Drawing.Size(75, 23);
            this.Milia.TabIndex = 4;
            this.Milia.Text = "миля";
            this.Milia.UseVisualStyleBackColor = true;
            this.Milia.Click += new System.EventHandler(this.Milia_Click);
            // 
            // Oknovivoda
            // 
            this.Oknovivoda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oknovivoda.Location = new System.Drawing.Point(166, 62);
            this.Oknovivoda.Name = "Oknovivoda";
            this.Oknovivoda.Size = new System.Drawing.Size(100, 23);
            this.Oknovivoda.TabIndex = 5;
            // 
            // Nazad
            // 
            this.Nazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nazad.BackgroundImage")));
            this.Nazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nazad.Location = new System.Drawing.Point(210, 146);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(56, 23);
            this.Nazad.TabIndex = 20;
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Oknovivoda);
            this.Controls.Add(this.Milia);
            this.Controls.Add(this.Duim);
            this.Controls.Add(this.Vvodtexta);
            this.Controls.Add(this.Resultatinfa);
            this.Controls.Add(this.Dlina);
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меры длины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dlina;
        private System.Windows.Forms.Label Resultatinfa;
        private System.Windows.Forms.TextBox Vvodtexta;
        private System.Windows.Forms.Button Duim;
        private System.Windows.Forms.Button Milia;
        private System.Windows.Forms.Label Oknovivoda;
        private System.Windows.Forms.Button Nazad;
    }
}