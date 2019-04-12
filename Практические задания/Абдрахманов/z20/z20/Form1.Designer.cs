namespace z20
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
            this.Cifri = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.Nomer = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.ListBox();
            this.Znakomstvo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cifri
            // 
            this.Cifri.AutoSize = true;
            this.Cifri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cifri.Location = new System.Drawing.Point(12, 32);
            this.Cifri.Name = "Cifri";
            this.Cifri.Size = new System.Drawing.Size(53, 16);
            this.Cifri.TabIndex = 0;
            this.Cifri.Text = "Цифры";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(93, 32);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 71);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(134, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "В начале номера";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(12, 109);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(134, 23);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "В конце номера";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Nomer
            // 
            this.Nomer.Location = new System.Drawing.Point(12, 148);
            this.Nomer.Name = "Nomer";
            this.Nomer.Size = new System.Drawing.Size(132, 26);
            this.Nomer.TabIndex = 4;
            this.Nomer.Text = "Содержатся в номере";
            this.Nomer.UseVisualStyleBackColor = true;
            this.Nomer.Click += new System.EventHandler(this.Nomer_Click);
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.Location = new System.Drawing.Point(153, 71);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(120, 173);
            this.Info.TabIndex = 5;
            // 
            // Znakomstvo
            // 
            this.Znakomstvo.Location = new System.Drawing.Point(15, 202);
            this.Znakomstvo.Name = "Znakomstvo";
            this.Znakomstvo.Size = new System.Drawing.Size(83, 23);
            this.Znakomstvo.TabIndex = 6;
            this.Znakomstvo.Text = "Знакомство";
            this.Znakomstvo.UseVisualStyleBackColor = true;
            this.Znakomstvo.Click += new System.EventHandler(this.Znakomstvo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Znakomstvo);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Nomer);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Cifri);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Поиск абонентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cifri;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Nomer;
        private System.Windows.Forms.ListBox Info;
        private System.Windows.Forms.Button Znakomstvo;
    }
}

