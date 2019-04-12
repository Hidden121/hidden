namespace z19
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
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Photo2 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(114, 102);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(100, 47);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            // 
            // Photo2
            // 
            this.Photo2.Image = ((System.Drawing.Image)(resources.GetObject("Photo2.Image")));
            this.Photo2.Location = new System.Drawing.Point(114, 46);
            this.Photo2.Name = "Photo2";
            this.Photo2.Size = new System.Drawing.Size(100, 50);
            this.Photo2.TabIndex = 2;
            this.Photo2.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переходToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(323, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Menu";
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            this.переходToolStripMenuItem.Click += new System.EventHandler(this.переходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 183);
            this.Controls.Add(this.Photo2);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(339, 222);
            this.MinimumSize = new System.Drawing.Size(339, 222);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.PictureBox Photo2;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
    }
}

