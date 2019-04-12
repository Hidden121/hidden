namespace z7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.OknoInfi = new System.Windows.Forms.RichTextBox();
            this.Panel = new System.Windows.Forms.ToolStrip();
            this.Vpered = new System.Windows.Forms.ToolStripButton();
            this.Nazad = new System.Windows.Forms.ToolStripButton();
            this.ZagrizitFail = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OknoInfi
            // 
            this.OknoInfi.Location = new System.Drawing.Point(39, 28);
            this.OknoInfi.Name = "OknoInfi";
            this.OknoInfi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.OknoInfi.Size = new System.Drawing.Size(253, 185);
            this.OknoInfi.TabIndex = 0;
            this.OknoInfi.Text = "";
            // 
            // Panel
            // 
            this.Panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Vpered,
            this.Nazad});
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(314, 25);
            this.Panel.TabIndex = 1;
            this.Panel.Text = "toolStrip1";
            // 
            // Vpered
            // 
            this.Vpered.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Vpered.Image = ((System.Drawing.Image)(resources.GetObject("Vpered.Image")));
            this.Vpered.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Vpered.Name = "Vpered";
            this.Vpered.Size = new System.Drawing.Size(23, 22);
            this.Vpered.Text = "toolStripButton1";
            this.Vpered.Click += new System.EventHandler(this.Vpered_Click);
            // 
            // Nazad
            // 
            this.Nazad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nazad.Image = ((System.Drawing.Image)(resources.GetObject("Nazad.Image")));
            this.Nazad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(23, 22);
            this.Nazad.Text = "toolStripButton2";
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // ZagrizitFail
            // 
            this.ZagrizitFail.Location = new System.Drawing.Point(39, 239);
            this.ZagrizitFail.Name = "ZagrizitFail";
            this.ZagrizitFail.Size = new System.Drawing.Size(253, 23);
            this.ZagrizitFail.TabIndex = 2;
            this.ZagrizitFail.Text = "Загрузить из файла";
            this.ZagrizitFail.UseVisualStyleBackColor = true;
            this.ZagrizitFail.Click += new System.EventHandler(this.ZagrizitFail_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(39, 268);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(80, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Далее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.ZagrizitFail);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.OknoInfi);
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена Файлов";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OknoInfi;
        private System.Windows.Forms.ToolStrip Panel;
        private System.Windows.Forms.Button ZagrizitFail;
        private System.Windows.Forms.ToolStripButton Vpered;
        private System.Windows.Forms.ToolStripButton Nazad;
        private System.Windows.Forms.Button Next;
    }
}