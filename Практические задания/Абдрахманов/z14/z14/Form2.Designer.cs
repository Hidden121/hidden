namespace z14
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
            this.Ishodnie = new System.Windows.Forms.Label();
            this.Polojiteknie = new System.Windows.Forms.Label();
            this.Otrichateknie = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.ListBox();
            this.Info2 = new System.Windows.Forms.ListBox();
            this.Info3 = new System.Windows.Forms.ListBox();
            this.Generirovat = new System.Windows.Forms.Button();
            this.Razdelit = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ishodnie
            // 
            this.Ishodnie.AutoSize = true;
            this.Ishodnie.Location = new System.Drawing.Point(29, 13);
            this.Ishodnie.Name = "Ishodnie";
            this.Ishodnie.Size = new System.Drawing.Size(58, 13);
            this.Ishodnie.TabIndex = 0;
            this.Ishodnie.Text = "Исходные";
            // 
            // Polojiteknie
            // 
            this.Polojiteknie.AutoSize = true;
            this.Polojiteknie.Location = new System.Drawing.Point(131, 13);
            this.Polojiteknie.Name = "Polojiteknie";
            this.Polojiteknie.Size = new System.Drawing.Size(90, 13);
            this.Polojiteknie.TabIndex = 1;
            this.Polojiteknie.Text = "Положительные";
            // 
            // Otrichateknie
            // 
            this.Otrichateknie.AutoSize = true;
            this.Otrichateknie.Location = new System.Drawing.Point(260, 13);
            this.Otrichateknie.Name = "Otrichateknie";
            this.Otrichateknie.Size = new System.Drawing.Size(87, 13);
            this.Otrichateknie.TabIndex = 2;
            this.Otrichateknie.Text = "Отрицательные";
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.Location = new System.Drawing.Point(12, 42);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(86, 173);
            this.Info.TabIndex = 3;
            // 
            // Info2
            // 
            this.Info2.FormattingEnabled = true;
            this.Info2.Location = new System.Drawing.Point(130, 42);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(91, 173);
            this.Info2.TabIndex = 4;
            // 
            // Info3
            // 
            this.Info3.FormattingEnabled = true;
            this.Info3.Location = new System.Drawing.Point(256, 42);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(91, 173);
            this.Info3.TabIndex = 5;
            // 
            // Generirovat
            // 
            this.Generirovat.Location = new System.Drawing.Point(12, 226);
            this.Generirovat.Name = "Generirovat";
            this.Generirovat.Size = new System.Drawing.Size(86, 23);
            this.Generirovat.TabIndex = 6;
            this.Generirovat.Text = "Генерировать";
            this.Generirovat.UseVisualStyleBackColor = true;
            this.Generirovat.Click += new System.EventHandler(this.Generirovat_Click);
            // 
            // Razdelit
            // 
            this.Razdelit.Location = new System.Drawing.Point(134, 225);
            this.Razdelit.Name = "Razdelit";
            this.Razdelit.Size = new System.Drawing.Size(75, 23);
            this.Razdelit.TabIndex = 7;
            this.Razdelit.Text = "Разделить";
            this.Razdelit.UseVisualStyleBackColor = true;
            this.Razdelit.Click += new System.EventHandler(this.Razdelit_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(263, 225);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Razdelit);
            this.Controls.Add(this.Generirovat);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Otrichateknie);
            this.Controls.Add(this.Polojiteknie);
            this.Controls.Add(this.Ishodnie);
            this.Name = "Form2";
            this.Text = "Задание 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ishodnie;
        private System.Windows.Forms.Label Polojiteknie;
        private System.Windows.Forms.Label Otrichateknie;
        private System.Windows.Forms.ListBox Info;
        private System.Windows.Forms.ListBox Info2;
        private System.Windows.Forms.ListBox Info3;
        private System.Windows.Forms.Button Generirovat;
        private System.Windows.Forms.Button Razdelit;
        private System.Windows.Forms.Button OK;
    }
}