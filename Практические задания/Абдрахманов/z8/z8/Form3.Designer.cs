namespace z8
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.одеждаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.числоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Label();
            this.Chislo = new System.Windows.Forms.Label();
            this.Perehod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одеждаToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.датаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // одеждаToolStripMenuItem
            // 
            this.одеждаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("одеждаToolStripMenuItem.Image")));
            this.одеждаToolStripMenuItem.Name = "одеждаToolStripMenuItem";
            this.одеждаToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.одеждаToolStripMenuItem.Text = "Одежда";
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оборудованиеToolStripMenuItem.Image")));
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("инструментыToolStripMenuItem.Image")));
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // датаToolStripMenuItem
            // 
            this.датаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.числоToolStripMenuItem,
            this.времяToolStripMenuItem});
            this.датаToolStripMenuItem.Name = "датаToolStripMenuItem";
            this.датаToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.датаToolStripMenuItem.Text = "Дата";
            // 
            // числоToolStripMenuItem
            // 
            this.числоToolStripMenuItem.Name = "числоToolStripMenuItem";
            this.числоToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.числоToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.числоToolStripMenuItem.Text = "Число";
            this.числоToolStripMenuItem.Click += new System.EventHandler(this.числоToolStripMenuItem_Click);
            // 
            // времяToolStripMenuItem
            // 
            this.времяToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.времяToolStripMenuItem.Name = "времяToolStripMenuItem";
            this.времяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.времяToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.времяToolStripMenuItem.Text = "Время";
            this.времяToolStripMenuItem.Click += new System.EventHandler(this.времяToolStripMenuItem_Click);
            // 
            // Time
            // 
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Time.Cursor = System.Windows.Forms.Cursors.Default;
            this.Time.Location = new System.Drawing.Point(131, 53);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 23);
            this.Time.TabIndex = 1;
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Chislo
            // 
            this.Chislo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Chislo.Location = new System.Drawing.Point(12, 53);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(100, 23);
            this.Chislo.TabIndex = 2;
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(12, 176);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 3;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = true;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 218);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Chislo);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(367, 245);
            this.MinimumSize = new System.Drawing.Size(367, 245);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem одеждаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem числоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяToolStripMenuItem;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Chislo;
        private System.Windows.Forms.Button Perehod;
    }
}