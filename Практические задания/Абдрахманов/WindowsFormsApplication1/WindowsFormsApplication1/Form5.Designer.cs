namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.OknoInfi = new System.Windows.Forms.ListBox();
            this.OknoInfi2 = new System.Windows.Forms.ListBox();
            this.KnopkaPerevodavinfi2 = new System.Windows.Forms.Button();
            this.Vvodtexta = new System.Windows.Forms.TextBox();
            this.KnopkaDobavleniaTexta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OknoInfi
            // 
            this.OknoInfi.FormattingEnabled = true;
            this.OknoInfi.Items.AddRange(new object[] {
            "86778ds8766",
            "1111qqa0",
            "2321hgf",
            "43ds"});
            this.OknoInfi.Location = new System.Drawing.Point(12, 12);
            this.OknoInfi.Name = "OknoInfi";
            this.OknoInfi.Size = new System.Drawing.Size(120, 160);
            this.OknoInfi.TabIndex = 0;
            // 
            // OknoInfi2
            // 
            this.OknoInfi2.FormattingEnabled = true;
            this.OknoInfi2.Location = new System.Drawing.Point(152, 12);
            this.OknoInfi2.Name = "OknoInfi2";
            this.OknoInfi2.Size = new System.Drawing.Size(120, 160);
            this.OknoInfi2.TabIndex = 1;
            // 
            // KnopkaPerevodavinfi2
            // 
            this.KnopkaPerevodavinfi2.Location = new System.Drawing.Point(12, 208);
            this.KnopkaPerevodavinfi2.Name = "KnopkaPerevodavinfi2";
            this.KnopkaPerevodavinfi2.Size = new System.Drawing.Size(124, 23);
            this.KnopkaPerevodavinfi2.TabIndex = 2;
            this.KnopkaPerevodavinfi2.Text = "Вывести цифры";
            this.KnopkaPerevodavinfi2.UseVisualStyleBackColor = true;
            this.KnopkaPerevodavinfi2.Click += new System.EventHandler(this.KnopkaPerevodavinfi2_Click);
            // 
            // Vvodtexta
            // 
            this.Vvodtexta.Location = new System.Drawing.Point(44, 182);
            this.Vvodtexta.Name = "Vvodtexta";
            this.Vvodtexta.Size = new System.Drawing.Size(100, 20);
            this.Vvodtexta.TabIndex = 7;
            // 
            // KnopkaDobavleniaTexta
            // 
            this.KnopkaDobavleniaTexta.Location = new System.Drawing.Point(12, 180);
            this.KnopkaDobavleniaTexta.Name = "KnopkaDobavleniaTexta";
            this.KnopkaDobavleniaTexta.Size = new System.Drawing.Size(26, 23);
            this.KnopkaDobavleniaTexta.TabIndex = 6;
            this.KnopkaDobavleniaTexta.Text = "@";
            this.KnopkaDobavleniaTexta.UseVisualStyleBackColor = true;
            this.KnopkaDobavleniaTexta.Click += new System.EventHandler(this.KnopkaDobavleniaTexta_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Vvodtexta);
            this.Controls.Add(this.KnopkaDobavleniaTexta);
            this.Controls.Add(this.KnopkaPerevodavinfi2);
            this.Controls.Add(this.OknoInfi2);
            this.Controls.Add(this.OknoInfi);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OknoInfi;
        private System.Windows.Forms.ListBox OknoInfi2;
        private System.Windows.Forms.Button KnopkaPerevodavinfi2;
        private System.Windows.Forms.TextBox Vvodtexta;
        private System.Windows.Forms.Button KnopkaDobavleniaTexta;
    }
}