namespace z18
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
            this.Time1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Photo5 = new System.Windows.Forms.PictureBox();
            this.Photo3 = new System.Windows.Forms.PictureBox();
            this.Photo2 = new System.Windows.Forms.PictureBox();
            this.Photo4 = new System.Windows.Forms.PictureBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Time1
            // 
            this.Time1.Enabled = true;
            this.Time1.Interval = 20;
            this.Time1.Tick += new System.EventHandler(this.Time1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            this.переходToolStripMenuItem.Click += new System.EventHandler(this.переходToolStripMenuItem_Click);
            // 
            // Photo5
            // 
            this.Photo5.Image = ((System.Drawing.Image)(resources.GetObject("Photo5.Image")));
            this.Photo5.Location = new System.Drawing.Point(175, 46);
            this.Photo5.Name = "Photo5";
            this.Photo5.Size = new System.Drawing.Size(50, 45);
            this.Photo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo5.TabIndex = 4;
            this.Photo5.TabStop = false;
            // 
            // Photo3
            // 
            this.Photo3.Image = ((System.Drawing.Image)(resources.GetObject("Photo3.Image")));
            this.Photo3.Location = new System.Drawing.Point(23, 112);
            this.Photo3.Name = "Photo3";
            this.Photo3.Size = new System.Drawing.Size(55, 40);
            this.Photo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo3.TabIndex = 3;
            this.Photo3.TabStop = false;
            // 
            // Photo2
            // 
            this.Photo2.Image = ((System.Drawing.Image)(resources.GetObject("Photo2.Image")));
            this.Photo2.Location = new System.Drawing.Point(103, 46);
            this.Photo2.Name = "Photo2";
            this.Photo2.Size = new System.Drawing.Size(52, 45);
            this.Photo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo2.TabIndex = 2;
            this.Photo2.TabStop = false;
            // 
            // Photo4
            // 
            this.Photo4.Image = ((System.Drawing.Image)(resources.GetObject("Photo4.Image")));
            this.Photo4.Location = new System.Drawing.Point(106, 112);
            this.Photo4.Name = "Photo4";
            this.Photo4.Size = new System.Drawing.Size(49, 40);
            this.Photo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo4.TabIndex = 1;
            this.Photo4.TabStop = false;
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(23, 46);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(55, 45);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.Photo5);
            this.Controls.Add(this.Photo3);
            this.Controls.Add(this.Photo2);
            this.Controls.Add(this.Photo4);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "Form1";
            this.Text = "Звездное небо";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Timer Time1;
        private System.Windows.Forms.PictureBox Photo4;
        private System.Windows.Forms.PictureBox Photo2;
        private System.Windows.Forms.PictureBox Photo3;
        private System.Windows.Forms.PictureBox Photo5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
    }
}

