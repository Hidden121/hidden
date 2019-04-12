namespace z10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Photo = new System.Windows.Forms.PictureBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.сменитьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наВесьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Vpered = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SlaidShow = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(12, 89);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(285, 172);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Location = new System.Drawing.Point(12, 27);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(97, 20);
            this.domainUpDown1.TabIndex = 1;
            this.domainUpDown1.Text = "1";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьРисунокToolStripMenuItem,
            this.наВесьРисунокToolStripMenuItem,
            this.вернутьРазмерToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(323, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // сменитьРисунокToolStripMenuItem
            // 
            this.сменитьРисунокToolStripMenuItem.Name = "сменитьРисунокToolStripMenuItem";
            this.сменитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.сменитьРисунокToolStripMenuItem.Text = "Сменить рисунок";
            this.сменитьРисунокToolStripMenuItem.Click += new System.EventHandler(this.сменитьРисунокToolStripMenuItem_Click);
            // 
            // наВесьРисунокToolStripMenuItem
            // 
            this.наВесьРисунокToolStripMenuItem.Name = "наВесьРисунокToolStripMenuItem";
            this.наВесьРисунокToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.наВесьРисунокToolStripMenuItem.Text = "На весь экран";
            this.наВесьРисунокToolStripMenuItem.Click += new System.EventHandler(this.наВесьРисунокToolStripMenuItem_Click);
            // 
            // вернутьРазмерToolStripMenuItem
            // 
            this.вернутьРазмерToolStripMenuItem.Name = "вернутьРазмерToolStripMenuItem";
            this.вернутьРазмерToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.вернутьРазмерToolStripMenuItem.Text = "Вернуть размер";
            this.вернутьРазмерToolStripMenuItem.Click += new System.EventHandler(this.вернутьРазмерToolStripMenuItem_Click);
            // 
            // Vpered
            // 
            this.Vpered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Vpered.BackgroundImage")));
            this.Vpered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Vpered.Location = new System.Drawing.Point(63, 53);
            this.Vpered.Name = "Vpered";
            this.Vpered.Size = new System.Drawing.Size(46, 23);
            this.Vpered.TabIndex = 3;
            this.Vpered.UseVisualStyleBackColor = true;
            this.Vpered.Click += new System.EventHandler(this.Vpered_Click);
            // 
            // Nazad
            // 
            this.Nazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nazad.BackgroundImage")));
            this.Nazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nazad.Location = new System.Drawing.Point(12, 53);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(45, 23);
            this.Nazad.TabIndex = 4;
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // SlaidShow
            // 
            this.SlaidShow.Location = new System.Drawing.Point(128, 27);
            this.SlaidShow.Name = "SlaidShow";
            this.SlaidShow.Size = new System.Drawing.Size(75, 23);
            this.SlaidShow.TabIndex = 5;
            this.SlaidShow.Text = "Слайд-шоу";
            this.SlaidShow.UseVisualStyleBackColor = true;
            this.SlaidShow.Click += new System.EventHandler(this.SlaidShow_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(222, 27);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Остановить";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 300);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.SlaidShow);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Vpered);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Рисунок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem сменитьРисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наВесьРисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьРазмерToolStripMenuItem;
        private System.Windows.Forms.Button Vpered;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button SlaidShow;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer Time;
    }
}

