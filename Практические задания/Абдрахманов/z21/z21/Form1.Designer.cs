namespace z21
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заглавныеБуквыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строчныеБуквыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСимволовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Box = new System.Windows.Forms.TextBox();
            this.Naiti = new System.Windows.Forms.TextBox();
            this.Poisk = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Otvet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Zamena = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.анализТекстаToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(310, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.заглавныеБуквыToolStripMenuItem,
            this.строчныеБуквыToolStripMenuItem});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // заглавныеБуквыToolStripMenuItem
            // 
            this.заглавныеБуквыToolStripMenuItem.Name = "заглавныеБуквыToolStripMenuItem";
            this.заглавныеБуквыToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.заглавныеБуквыToolStripMenuItem.Text = "Заглавные буквы";
            this.заглавныеБуквыToolStripMenuItem.Click += new System.EventHandler(this.заглавныеБуквыToolStripMenuItem_Click);
            // 
            // строчныеБуквыToolStripMenuItem
            // 
            this.строчныеБуквыToolStripMenuItem.Name = "строчныеБуквыToolStripMenuItem";
            this.строчныеБуквыToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.строчныеБуквыToolStripMenuItem.Text = "Строчные буквы";
            this.строчныеБуквыToolStripMenuItem.Click += new System.EventHandler(this.строчныеБуквыToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиToolStripMenuItem,
            this.заменитьToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.заменитьToolStripMenuItem.Text = "Заменить";
            this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
            // 
            // анализТекстаToolStripMenuItem
            // 
            this.анализТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоСловToolStripMenuItem,
            this.количествоСимволовToolStripMenuItem});
            this.анализТекстаToolStripMenuItem.Name = "анализТекстаToolStripMenuItem";
            this.анализТекстаToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.анализТекстаToolStripMenuItem.Text = "Анализ текста";
            // 
            // количествоСловToolStripMenuItem
            // 
            this.количествоСловToolStripMenuItem.Name = "количествоСловToolStripMenuItem";
            this.количествоСловToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.количествоСловToolStripMenuItem.Text = "Количество слов";
            this.количествоСловToolStripMenuItem.Click += new System.EventHandler(this.количествоСловToolStripMenuItem_Click);
            // 
            // количествоСимволовToolStripMenuItem
            // 
            this.количествоСимволовToolStripMenuItem.Name = "количествоСимволовToolStripMenuItem";
            this.количествоСимволовToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.количествоСимволовToolStripMenuItem.Text = "Количество символов";
            this.количествоСимволовToolStripMenuItem.Click += new System.EventHandler(this.количествоСимволовToolStripMenuItem_Click);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(13, 41);
            this.Box.Multiline = true;
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(279, 150);
            this.Box.TabIndex = 1;
            // 
            // Naiti
            // 
            this.Naiti.Location = new System.Drawing.Point(13, 262);
            this.Naiti.Name = "Naiti";
            this.Naiti.Size = new System.Drawing.Size(123, 20);
            this.Naiti.TabIndex = 2;
            // 
            // Poisk
            // 
            this.Poisk.AutoSize = true;
            this.Poisk.Location = new System.Drawing.Point(27, 237);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(93, 13);
            this.Poisk.TabIndex = 3;
            this.Poisk.Text = "Условия поиска:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(194, 237);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(59, 13);
            this.Result.TabIndex = 4;
            this.Result.Text = "Результат";
            // 
            // Otvet
            // 
            this.Otvet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Otvet.Location = new System.Drawing.Point(142, 262);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(150, 23);
            this.Otvet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Заменяем на:";
            // 
            // Zamena
            // 
            this.Zamena.Location = new System.Drawing.Point(13, 325);
            this.Zamena.Name = "Zamena";
            this.Zamena.Size = new System.Drawing.Size(123, 20);
            this.Zamena.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Zamena);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.Naiti);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(326, 404);
            this.MinimumSize = new System.Drawing.Size(326, 404);
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заглавныеБуквыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строчныеБуквыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоСимволовToolStripMenuItem;
        private System.Windows.Forms.TextBox Box;
        private System.Windows.Forms.TextBox Naiti;
        private System.Windows.Forms.Label Poisk;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Otvet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Zamena;
    }
}

