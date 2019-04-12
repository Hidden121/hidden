namespace z9
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
            this.components = new System.ComponentModel.Container();
            this.Perehod = new System.Windows.Forms.Button();
            this.Kartinka = new System.Windows.Forms.PictureBox();
            this.Vivod = new System.Windows.Forms.Label();
            this.Описание = new System.Windows.Forms.Label();
            this.Artical = new System.Windows.Forms.Label();
            this.Артикул = new System.Windows.Forms.Label();
            this.VivodCeni = new System.Windows.Forms.Label();
            this.ViborPlati = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Цена = new System.Windows.Forms.Label();
            this.Модель = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(184, 273);
            this.Perehod.MaximumSize = new System.Drawing.Size(350, 350);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 28;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Kartinka
            // 
            this.Kartinka.Location = new System.Drawing.Point(158, 145);
            this.Kartinka.Name = "Kartinka";
            this.Kartinka.Size = new System.Drawing.Size(120, 120);
            this.Kartinka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kartinka.TabIndex = 27;
            this.Kartinka.TabStop = false;
            // 
            // Vivod
            // 
            this.Vivod.BackColor = System.Drawing.SystemColors.Control;
            this.Vivod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Vivod.Location = new System.Drawing.Point(16, 131);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(121, 134);
            this.Vivod.TabIndex = 26;
            // 
            // Описание
            // 
            this.Описание.AutoSize = true;
            this.Описание.Location = new System.Drawing.Point(15, 95);
            this.Описание.Name = "Описание";
            this.Описание.Size = new System.Drawing.Size(57, 13);
            this.Описание.TabIndex = 25;
            this.Описание.Text = "Описание";
            // 
            // Artical
            // 
            this.Artical.BackColor = System.Drawing.SystemColors.Control;
            this.Artical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Artical.Location = new System.Drawing.Point(158, 110);
            this.Artical.Name = "Artical";
            this.Artical.Size = new System.Drawing.Size(120, 22);
            this.Artical.TabIndex = 24;
            // 
            // Артикул
            // 
            this.Артикул.AutoSize = true;
            this.Артикул.Location = new System.Drawing.Point(181, 83);
            this.Артикул.Name = "Артикул";
            this.Артикул.Size = new System.Drawing.Size(48, 13);
            this.Артикул.TabIndex = 23;
            this.Артикул.Text = "Артикул";
            // 
            // VivodCeni
            // 
            this.VivodCeni.BackColor = System.Drawing.SystemColors.Control;
            this.VivodCeni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VivodCeni.Location = new System.Drawing.Point(158, 42);
            this.VivodCeni.Name = "VivodCeni";
            this.VivodCeni.Size = new System.Drawing.Size(120, 23);
            this.VivodCeni.TabIndex = 22;
            // 
            // ViborPlati
            // 
            this.ViborPlati.ContextMenuStrip = this.contextMenuStrip1;
            this.ViborPlati.FormattingEnabled = true;
            this.ViborPlati.Location = new System.Drawing.Point(16, 42);
            this.ViborPlati.Name = "ViborPlati";
            this.ViborPlati.Size = new System.Drawing.Size(121, 21);
            this.ViborPlati.TabIndex = 21;
            this.ViborPlati.SelectedIndexChanged += new System.EventHandler(this.ViborPlati_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.заполнитьToolStripMenuItem,
            this.ценаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // заполнитьToolStripMenuItem
            // 
            this.заполнитьToolStripMenuItem.Name = "заполнитьToolStripMenuItem";
            this.заполнитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.заполнитьToolStripMenuItem.Text = "Заполнить";
            this.заполнитьToolStripMenuItem.Click += new System.EventHandler(this.заполнитьToolStripMenuItem_Click);
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem1});
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ценаToolStripMenuItem.Text = "Цена";
            // 
            // очиститьToolStripMenuItem1
            // 
            this.очиститьToolStripMenuItem1.Name = "очиститьToolStripMenuItem1";
            this.очиститьToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.очиститьToolStripMenuItem1.Text = "Очистить";
            this.очиститьToolStripMenuItem1.Click += new System.EventHandler(this.очиститьToolStripMenuItem1_Click);
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(181, 16);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(33, 13);
            this.Цена.TabIndex = 20;
            this.Цена.Text = "Цена";
            // 
            // Модель
            // 
            this.Модель.AutoSize = true;
            this.Модель.Location = new System.Drawing.Point(15, 16);
            this.Модель.Name = "Модель";
            this.Модель.Size = new System.Drawing.Size(46, 13);
            this.Модель.TabIndex = 19;
            this.Модель.Text = "Модель";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 325);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Kartinka);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Описание);
            this.Controls.Add(this.Artical);
            this.Controls.Add(this.Артикул);
            this.Controls.Add(this.VivodCeni);
            this.Controls.Add(this.ViborPlati);
            this.Controls.Add(this.Цена);
            this.Controls.Add(this.Модель);
            this.MaximumSize = new System.Drawing.Size(328, 352);
            this.MinimumSize = new System.Drawing.Size(328, 352);
            this.Name = "Form1";
            this.Text = "Винчестер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.PictureBox Kartinka;
        private System.Windows.Forms.Label Vivod;
        private System.Windows.Forms.Label Описание;
        private System.Windows.Forms.Label Artical;
        private System.Windows.Forms.Label Артикул;
        private System.Windows.Forms.Label VivodCeni;
        private System.Windows.Forms.ComboBox ViborPlati;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.Label Модель;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem1;

    }
}

