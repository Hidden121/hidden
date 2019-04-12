namespace WindowsFormsApplication1
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
            this.OknoInfi = new System.Windows.Forms.ListBox();
            this.KolvoCifr = new System.Windows.Forms.Button();
            this.Perehod = new System.Windows.Forms.Button();
            this.OknoTexta = new System.Windows.Forms.TextBox();
            this.KnopkaDobaleniaTexta = new System.Windows.Forms.Button();
            this.Vivod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OknoInfi
            // 
            this.OknoInfi.FormattingEnabled = true;
            this.OknoInfi.Items.AddRange(new object[] {
            "123414",
            "321ere",
            "124113q",
            "eredrs"});
            this.OknoInfi.Location = new System.Drawing.Point(13, 13);
            this.OknoInfi.Name = "OknoInfi";
            this.OknoInfi.Size = new System.Drawing.Size(248, 108);
            this.OknoInfi.TabIndex = 0;
            this.OknoInfi.SelectedIndexChanged += new System.EventHandler(this.OknoInfi_SelectedIndexChanged);
            // 
            // KolvoCifr
            // 
            this.KolvoCifr.Location = new System.Drawing.Point(13, 157);
            this.KolvoCifr.Name = "KolvoCifr";
            this.KolvoCifr.Size = new System.Drawing.Size(112, 23);
            this.KolvoCifr.TabIndex = 1;
            this.KolvoCifr.Text = "Количество цифр";
            this.KolvoCifr.UseVisualStyleBackColor = true;
            this.KolvoCifr.Click += new System.EventHandler(this.KolvoCifr_Click);
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(153, 157);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(108, 23);
            this.Perehod.TabIndex = 3;
            this.Perehod.Text = "Переход на form5";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // OknoTexta
            // 
            this.OknoTexta.Location = new System.Drawing.Point(48, 131);
            this.OknoTexta.Name = "OknoTexta";
            this.OknoTexta.Size = new System.Drawing.Size(100, 20);
            this.OknoTexta.TabIndex = 7;
            // 
            // KnopkaDobaleniaTexta
            // 
            this.KnopkaDobaleniaTexta.Location = new System.Drawing.Point(16, 128);
            this.KnopkaDobaleniaTexta.Name = "KnopkaDobaleniaTexta";
            this.KnopkaDobaleniaTexta.Size = new System.Drawing.Size(26, 23);
            this.KnopkaDobaleniaTexta.TabIndex = 6;
            this.KnopkaDobaleniaTexta.Text = "@";
            this.KnopkaDobaleniaTexta.UseVisualStyleBackColor = true;
            this.KnopkaDobaleniaTexta.Click += new System.EventHandler(this.KnopkaDobaleniaTexta_Click);
            // 
            // Vivod
            // 
            this.Vivod.AutoSize = true;
            this.Vivod.Location = new System.Drawing.Point(13, 192);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(0, 13);
            this.Vivod.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.OknoTexta);
            this.Controls.Add(this.KnopkaDobaleniaTexta);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.KolvoCifr);
            this.Controls.Add(this.OknoInfi);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form4";
            this.Text = "Кол-во цифр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OknoInfi;
        private System.Windows.Forms.Button KolvoCifr;
        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.TextBox OknoTexta;
        private System.Windows.Forms.Button KnopkaDobaleniaTexta;
        private System.Windows.Forms.Label Vivod;
    }
}