namespace z22
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Slova = new System.Windows.Forms.Label();
            this.Razdelit = new System.Windows.Forms.Button();
            this.KolvoSlov = new System.Windows.Forms.Button();
            this.Naitislovo = new System.Windows.Forms.Button();
            this.Samoedlinoeslovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Vvod3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(13, 13);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(40, 13);
            this.Text.TabIndex = 0;
            this.Text.Text = "Текст:";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(14, 38);
            this.Vvod.Multiline = true;
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(188, 173);
            this.Vvod.TabIndex = 1;
            // 
            // Slova
            // 
            this.Slova.AutoSize = true;
            this.Slova.Location = new System.Drawing.Point(209, 13);
            this.Slova.Name = "Slova";
            this.Slova.Size = new System.Drawing.Size(41, 13);
            this.Slova.TabIndex = 3;
            this.Slova.Text = "Слова:";
            // 
            // Razdelit
            // 
            this.Razdelit.Location = new System.Drawing.Point(14, 224);
            this.Razdelit.Name = "Razdelit";
            this.Razdelit.Size = new System.Drawing.Size(188, 23);
            this.Razdelit.TabIndex = 4;
            this.Razdelit.Text = "Разделить на слова";
            this.Razdelit.UseVisualStyleBackColor = true;
            this.Razdelit.Click += new System.EventHandler(this.Razdelit_Click);
            // 
            // KolvoSlov
            // 
            this.KolvoSlov.Location = new System.Drawing.Point(16, 253);
            this.KolvoSlov.Name = "KolvoSlov";
            this.KolvoSlov.Size = new System.Drawing.Size(186, 23);
            this.KolvoSlov.TabIndex = 5;
            this.KolvoSlov.Text = "Количество слов";
            this.KolvoSlov.UseVisualStyleBackColor = true;
            this.KolvoSlov.Click += new System.EventHandler(this.KolvoSlov_Click);
            // 
            // Naitislovo
            // 
            this.Naitislovo.Location = new System.Drawing.Point(16, 282);
            this.Naitislovo.Name = "Naitislovo";
            this.Naitislovo.Size = new System.Drawing.Size(186, 23);
            this.Naitislovo.TabIndex = 6;
            this.Naitislovo.Text = "Найти слово";
            this.Naitislovo.UseVisualStyleBackColor = true;
            this.Naitislovo.Click += new System.EventHandler(this.Naitislovo_Click);
            // 
            // Samoedlinoeslovo
            // 
            this.Samoedlinoeslovo.Location = new System.Drawing.Point(16, 311);
            this.Samoedlinoeslovo.Name = "Samoedlinoeslovo";
            this.Samoedlinoeslovo.Size = new System.Drawing.Size(186, 23);
            this.Samoedlinoeslovo.TabIndex = 7;
            this.Samoedlinoeslovo.Text = "Самое длинное слово";
            this.Samoedlinoeslovo.UseVisualStyleBackColor = true;
            this.Samoedlinoeslovo.Click += new System.EventHandler(this.Samoedlinoeslovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Vvod3
            // 
            this.Vvod3.Location = new System.Drawing.Point(215, 253);
            this.Vvod3.Name = "Vvod3";
            this.Vvod3.Size = new System.Drawing.Size(100, 20);
            this.Vvod3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.Items.AddRange(new object[] {
            "Привет",
            "Алоха",
            "Хай"});
            this.Info.Location = new System.Drawing.Point(209, 38);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(119, 173);
            this.Info.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 354);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vvod3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Samoedlinoeslovo);
            this.Controls.Add(this.Naitislovo);
            this.Controls.Add(this.KolvoSlov);
            this.Controls.Add(this.Razdelit);
            this.Controls.Add(this.Slova);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Text);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Label Slova;
        private System.Windows.Forms.Button Razdelit;
        private System.Windows.Forms.Button KolvoSlov;
        private System.Windows.Forms.Button Naitislovo;
        private System.Windows.Forms.Button Samoedlinoeslovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Vvod3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Info;
    }
}

