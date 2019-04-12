namespace WindowsFormsApplication1
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
            this.ViborPredlojnia = new System.Windows.Forms.ListBox();
            this.KolvoSlov = new System.Windows.Forms.Button();
            this.VivodInfo = new System.Windows.Forms.Label();
            this.Perehod = new System.Windows.Forms.Button();
            this.KnopkaDobavlenia = new System.Windows.Forms.Button();
            this.DobavleniaTexta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ViborPredlojnia
            // 
            this.ViborPredlojnia.FormattingEnabled = true;
            this.ViborPredlojnia.Items.AddRange(new object[] {
            "Мама мыла раму",
            "Привет мир!",
            "Томский политехнический университет",
            "Visual C#"});
            this.ViborPredlojnia.Location = new System.Drawing.Point(13, 13);
            this.ViborPredlojnia.Name = "ViborPredlojnia";
            this.ViborPredlojnia.Size = new System.Drawing.Size(246, 173);
            this.ViborPredlojnia.TabIndex = 0;
            // 
            // KolvoSlov
            // 
            this.KolvoSlov.Location = new System.Drawing.Point(12, 226);
            this.KolvoSlov.Name = "KolvoSlov";
            this.KolvoSlov.Size = new System.Drawing.Size(133, 23);
            this.KolvoSlov.TabIndex = 1;
            this.KolvoSlov.Text = "Количество слов";
            this.KolvoSlov.UseVisualStyleBackColor = true;
            this.KolvoSlov.Click += new System.EventHandler(this.KolvoSlov_Click);
            // 
            // VivodInfo
            // 
            this.VivodInfo.AutoSize = true;
            this.VivodInfo.Location = new System.Drawing.Point(166, 231);
            this.VivodInfo.Name = "VivodInfo";
            this.VivodInfo.Size = new System.Drawing.Size(93, 13);
            this.VivodInfo.TabIndex = 2;
            this.VivodInfo.Text = "Количество слов";
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(155, 192);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(104, 23);
            this.Perehod.TabIndex = 3;
            this.Perehod.Text = "Переход на form3";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // KnopkaDobavlenia
            // 
            this.KnopkaDobavlenia.Location = new System.Drawing.Point(13, 192);
            this.KnopkaDobavlenia.Name = "KnopkaDobavlenia";
            this.KnopkaDobavlenia.Size = new System.Drawing.Size(26, 23);
            this.KnopkaDobavlenia.TabIndex = 4;
            this.KnopkaDobavlenia.Text = "@";
            this.KnopkaDobavlenia.UseVisualStyleBackColor = true;
            this.KnopkaDobavlenia.Click += new System.EventHandler(this.KnopkaDobavlenia_Click);
            // 
            // DobavleniaTexta
            // 
            this.DobavleniaTexta.Location = new System.Drawing.Point(45, 194);
            this.DobavleniaTexta.Name = "DobavleniaTexta";
            this.DobavleniaTexta.Size = new System.Drawing.Size(100, 20);
            this.DobavleniaTexta.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DobavleniaTexta);
            this.Controls.Add(this.KnopkaDobavlenia);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.VivodInfo);
            this.Controls.Add(this.KolvoSlov);
            this.Controls.Add(this.ViborPredlojnia);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form2";
            this.Text = "Обработка строк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ViborPredlojnia;
        private System.Windows.Forms.Button KolvoSlov;
        private System.Windows.Forms.Label VivodInfo;
        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.Button KnopkaDobavlenia;
        private System.Windows.Forms.TextBox DobavleniaTexta;
    }
}