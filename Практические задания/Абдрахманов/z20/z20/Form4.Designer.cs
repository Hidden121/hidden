namespace z20
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
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.ListBox();
            this.Formirovat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Vivod = new System.Windows.Forms.Label();
            this.Perehod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список студентов";
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.Items.AddRange(new object[] {
            "Иванов",
            "Петров",
            "Сидоров"});
            this.Info.Location = new System.Drawing.Point(16, 40);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(120, 95);
            this.Info.TabIndex = 1;
            // 
            // Formirovat
            // 
            this.Formirovat.Location = new System.Drawing.Point(145, 112);
            this.Formirovat.Name = "Formirovat";
            this.Formirovat.Size = new System.Drawing.Size(247, 23);
            this.Formirovat.TabIndex = 2;
            this.Formirovat.Text = "Формировать текст приказа";
            this.Formirovat.UseVisualStyleBackColor = true;
            this.Formirovat.Click += new System.EventHandler(this.Formirovat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Приказ о награждении грамотой ";
            // 
            // Vivod
            // 
            this.Vivod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Vivod.Location = new System.Drawing.Point(16, 178);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(376, 123);
            this.Vivod.TabIndex = 4;
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(145, 40);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 5;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 322);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Formirovat);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Объединение строк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Info;
        private System.Windows.Forms.Button Formirovat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Vivod;
        private System.Windows.Forms.Button Perehod;
    }
}