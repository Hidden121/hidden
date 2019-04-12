namespace z11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ishodnoechislo = new System.Windows.Forms.Label();
            this.Delimostna2 = new System.Windows.Forms.Button();
            this.Delimostna3 = new System.Windows.Forms.Button();
            this.Delimostna5 = new System.Windows.Forms.Button();
            this.Vvodtexta = new System.Windows.Forms.TextBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Dalee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Ishodnoechislo
            // 
            this.Ishodnoechislo.AutoSize = true;
            this.Ishodnoechislo.Location = new System.Drawing.Point(13, 13);
            this.Ishodnoechislo.Name = "Ishodnoechislo";
            this.Ishodnoechislo.Size = new System.Drawing.Size(88, 13);
            this.Ishodnoechislo.TabIndex = 0;
            this.Ishodnoechislo.Text = "Исходное число";
            // 
            // Delimostna2
            // 
            this.Delimostna2.Location = new System.Drawing.Point(16, 39);
            this.Delimostna2.Name = "Delimostna2";
            this.Delimostna2.Size = new System.Drawing.Size(192, 23);
            this.Delimostna2.TabIndex = 1;
            this.Delimostna2.Text = "Делимость на 2";
            this.Delimostna2.UseVisualStyleBackColor = true;
            this.Delimostna2.Click += new System.EventHandler(this.Delimostna2_Click);
            // 
            // Delimostna3
            // 
            this.Delimostna3.Location = new System.Drawing.Point(16, 68);
            this.Delimostna3.Name = "Delimostna3";
            this.Delimostna3.Size = new System.Drawing.Size(192, 23);
            this.Delimostna3.TabIndex = 2;
            this.Delimostna3.Text = "Делимость на 3";
            this.Delimostna3.UseVisualStyleBackColor = true;
            this.Delimostna3.Click += new System.EventHandler(this.Delimostna3_Click);
            // 
            // Delimostna5
            // 
            this.Delimostna5.Location = new System.Drawing.Point(16, 97);
            this.Delimostna5.Name = "Delimostna5";
            this.Delimostna5.Size = new System.Drawing.Size(192, 23);
            this.Delimostna5.TabIndex = 3;
            this.Delimostna5.Text = "Делимость на 5";
            this.Delimostna5.UseVisualStyleBackColor = true;
            this.Delimostna5.Click += new System.EventHandler(this.Delimostna5_Click);
            // 
            // Vvodtexta
            // 
            this.Vvodtexta.Location = new System.Drawing.Point(108, 13);
            this.Vvodtexta.Name = "Vvodtexta";
            this.Vvodtexta.Size = new System.Drawing.Size(100, 20);
            this.Vvodtexta.TabIndex = 4;
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(244, 13);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(133, 143);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 5;
            this.Photo.TabStop = false;
            // 
            // Dalee
            // 
            this.Dalee.Location = new System.Drawing.Point(16, 136);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(192, 30);
            this.Dalee.TabIndex = 6;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.Dalee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 173);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Vvodtexta);
            this.Controls.Add(this.Delimostna5);
            this.Controls.Add(this.Delimostna3);
            this.Controls.Add(this.Delimostna2);
            this.Controls.Add(this.Ishodnoechislo);
            this.Name = "Form1";
            this.Text = "Проверка делимости числа ";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ishodnoechislo;
        private System.Windows.Forms.Button Delimostna2;
        private System.Windows.Forms.Button Delimostna3;
        private System.Windows.Forms.Button Delimostna5;
        private System.Windows.Forms.TextBox Vvodtexta;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button Dalee;
    }
}

