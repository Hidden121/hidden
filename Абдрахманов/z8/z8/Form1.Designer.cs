namespace z8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиНовогоСоперникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новичокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.любительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профессионалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьРазговорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовСправкиШашкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шашкиВИнтернетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеШашкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Perehod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиНовогоСоперникаToolStripMenuItem,
            this.уровеньToolStripMenuItem,
            this.включитьРазговорToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // найтиНовогоСоперникаToolStripMenuItem
            // 
            this.найтиНовогоСоперникаToolStripMenuItem.Name = "найтиНовогоСоперникаToolStripMenuItem";
            this.найтиНовогоСоперникаToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.найтиНовогоСоперникаToolStripMenuItem.Text = "Найти нового соперника";
            // 
            // уровеньToolStripMenuItem
            // 
            this.уровеньToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новичокToolStripMenuItem,
            this.любительToolStripMenuItem,
            this.профессионалToolStripMenuItem});
            this.уровеньToolStripMenuItem.Name = "уровеньToolStripMenuItem";
            this.уровеньToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.уровеньToolStripMenuItem.Text = "Уровень";
            // 
            // новичокToolStripMenuItem
            // 
            this.новичокToolStripMenuItem.Checked = true;
            this.новичокToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.новичокToolStripMenuItem.Name = "новичокToolStripMenuItem";
            this.новичокToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.новичокToolStripMenuItem.Text = "Новичок";
            // 
            // любительToolStripMenuItem
            // 
            this.любительToolStripMenuItem.Name = "любительToolStripMenuItem";
            this.любительToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.любительToolStripMenuItem.Text = "Любитель";
            // 
            // профессионалToolStripMenuItem
            // 
            this.профессионалToolStripMenuItem.Name = "профессионалToolStripMenuItem";
            this.профессионалToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.профессионалToolStripMenuItem.Text = "Профессионал";
            // 
            // включитьРазговорToolStripMenuItem
            // 
            this.включитьРазговорToolStripMenuItem.Checked = true;
            this.включитьРазговорToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.включитьРазговорToolStripMenuItem.Name = "включитьРазговорToolStripMenuItem";
            this.включитьРазговорToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.включитьРазговорToolStripMenuItem.Text = "Включить разговор при запуске";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиШашкиToolStripMenuItem,
            this.шашкиВИнтернетеToolStripMenuItem,
            this.оПрограммеШашкиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // вызовСправкиШашкиToolStripMenuItem
            // 
            this.вызовСправкиШашкиToolStripMenuItem.Name = "вызовСправкиШашкиToolStripMenuItem";
            this.вызовСправкиШашкиToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.вызовСправкиШашкиToolStripMenuItem.Text = "Вызов справки \"Шашки\"";
            // 
            // шашкиВИнтернетеToolStripMenuItem
            // 
            this.шашкиВИнтернетеToolStripMenuItem.Name = "шашкиВИнтернетеToolStripMenuItem";
            this.шашкиВИнтернетеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.шашкиВИнтернетеToolStripMenuItem.Text = "Шашки в Интернете";
            // 
            // оПрограммеШашкиToolStripMenuItem
            // 
            this.оПрограммеШашкиToolStripMenuItem.Name = "оПрограммеШашкиToolStripMenuItem";
            this.оПрограммеШашкиToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.оПрограммеШашкиToolStripMenuItem.Text = "О программе Шашки...";
            this.оПрограммеШашкиToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеШашкиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(7, 210);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 2;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 236);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(266, 263);
            this.MinimumSize = new System.Drawing.Size(266, 263);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиНовогоСоперникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьРазговорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новичокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem любительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профессионалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызовСправкиШашкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шашкиВИнтернетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеШашкиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Perehod;
    }
}

