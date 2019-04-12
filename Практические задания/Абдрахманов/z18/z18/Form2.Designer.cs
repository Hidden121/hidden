namespace z18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.New = new System.Windows.Forms.Label();
            this.Kontextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.быстрееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медленнееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Menyustrip = new System.Windows.Forms.MenuStrip();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kontextmenu.SuspendLayout();
            this.Menyustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.ContextMenuStrip = this.Kontextmenu;
            this.New.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.Maroon;
            this.New.Location = new System.Drawing.Point(72, 24);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(167, 33);
            this.New.TabIndex = 0;
            this.New.Text = "С новым годом";
            this.New.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kontextmenu
            // 
            this.Kontextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.быстрееToolStripMenuItem,
            this.медленнееToolStripMenuItem});
            this.Kontextmenu.Name = "Kontextmenu";
            this.Kontextmenu.Size = new System.Drawing.Size(137, 48);
            this.Kontextmenu.Opening += new System.ComponentModel.CancelEventHandler(this.Kontextmenu_Opening);
            // 
            // быстрееToolStripMenuItem
            // 
            this.быстрееToolStripMenuItem.Name = "быстрееToolStripMenuItem";
            this.быстрееToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.быстрееToolStripMenuItem.Text = "Быстрее";
            this.быстрееToolStripMenuItem.Click += new System.EventHandler(this.быстрееToolStripMenuItem_Click);
            // 
            // медленнееToolStripMenuItem
            // 
            this.медленнееToolStripMenuItem.Name = "медленнееToolStripMenuItem";
            this.медленнееToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.медленнееToolStripMenuItem.Text = "Медленнее";
            this.медленнееToolStripMenuItem.Click += new System.EventHandler(this.медленнееToolStripMenuItem_Click);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 50;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Menyustrip
            // 
            this.Menyustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переходToolStripMenuItem});
            this.Menyustrip.Location = new System.Drawing.Point(0, 0);
            this.Menyustrip.Name = "Menyustrip";
            this.Menyustrip.Size = new System.Drawing.Size(310, 24);
            this.Menyustrip.TabIndex = 2;
            this.Menyustrip.Text = "Menyistrip";
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            this.переходToolStripMenuItem.Click += new System.EventHandler(this.переходToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(310, 284);
            this.Controls.Add(this.Menyustrip);
            this.Controls.Add(this.New);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.Menyustrip;
            this.MaximumSize = new System.Drawing.Size(326, 323);
            this.MinimumSize = new System.Drawing.Size(326, 323);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Kontextmenu.ResumeLayout(false);
            this.Menyustrip.ResumeLayout(false);
            this.Menyustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label New;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ContextMenuStrip Kontextmenu;
        private System.Windows.Forms.ToolStripMenuItem быстрееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медленнееToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Menyustrip;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
    }
}