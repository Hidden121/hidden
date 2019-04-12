namespace WindowsFormsApplication1
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
            this.OknoInfi = new System.Windows.Forms.ListBox();
            this.Kolvonylei = new System.Windows.Forms.Button();
            this.KolvoEdinic = new System.Windows.Forms.Button();
            this.Vivod = new System.Windows.Forms.Label();
            this.Perehod = new System.Windows.Forms.Button();
            this.Vivod2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KnopkaDobavlenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OknoInfi
            // 
            this.OknoInfi.FormattingEnabled = true;
            this.OknoInfi.Items.AddRange(new object[] {
            "01010",
            "10101",
            "11010",
            "01011",
            "00010"});
            this.OknoInfi.Location = new System.Drawing.Point(12, 12);
            this.OknoInfi.Name = "OknoInfi";
            this.OknoInfi.Size = new System.Drawing.Size(241, 121);
            this.OknoInfi.TabIndex = 0;
            // 
            // Kolvonylei
            // 
            this.Kolvonylei.Location = new System.Drawing.Point(12, 168);
            this.Kolvonylei.Name = "Kolvonylei";
            this.Kolvonylei.Size = new System.Drawing.Size(94, 23);
            this.Kolvonylei.TabIndex = 1;
            this.Kolvonylei.Text = "Кол-во нулей";
            this.Kolvonylei.UseVisualStyleBackColor = true;
            this.Kolvonylei.Click += new System.EventHandler(this.Kolvonylei_Click);
            // 
            // KolvoEdinic
            // 
            this.KolvoEdinic.Location = new System.Drawing.Point(140, 168);
            this.KolvoEdinic.Name = "KolvoEdinic";
            this.KolvoEdinic.Size = new System.Drawing.Size(110, 23);
            this.KolvoEdinic.TabIndex = 2;
            this.KolvoEdinic.Text = "Кол-во единиц";
            this.KolvoEdinic.UseVisualStyleBackColor = true;
            this.KolvoEdinic.Click += new System.EventHandler(this.KolvoEdinic_Click);
            // 
            // Vivod
            // 
            this.Vivod.AutoSize = true;
            this.Vivod.Location = new System.Drawing.Point(12, 226);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(0, 13);
            this.Vivod.TabIndex = 3;
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(140, 139);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(113, 23);
            this.Perehod.TabIndex = 4;
            this.Perehod.Text = "Переход на form4";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Vivod2
            // 
            this.Vivod2.AutoSize = true;
            this.Vivod2.Location = new System.Drawing.Point(140, 226);
            this.Vivod2.Name = "Vivod2";
            this.Vivod2.Size = new System.Drawing.Size(0, 13);
            this.Vivod2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // KnopkaDobavlenia
            // 
            this.KnopkaDobavlenia.Location = new System.Drawing.Point(2, 137);
            this.KnopkaDobavlenia.Name = "KnopkaDobavlenia";
            this.KnopkaDobavlenia.Size = new System.Drawing.Size(26, 23);
            this.KnopkaDobavlenia.TabIndex = 6;
            this.KnopkaDobavlenia.Text = "@";
            this.KnopkaDobavlenia.UseVisualStyleBackColor = true;
            this.KnopkaDobavlenia.Click += new System.EventHandler(this.KnopkaDobavlenia_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KnopkaDobavlenia);
            this.Controls.Add(this.Vivod2);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.KolvoEdinic);
            this.Controls.Add(this.Kolvonylei);
            this.Controls.Add(this.OknoInfi);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OknoInfi;
        private System.Windows.Forms.Button Kolvonylei;
        private System.Windows.Forms.Button KolvoEdinic;
        private System.Windows.Forms.Label Vivod;
        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.Label Vivod2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button KnopkaDobavlenia;
    }
}