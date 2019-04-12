namespace zadanie4
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
            this.Perehod = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Ytverjdenia3 = new System.Windows.Forms.CheckBox();
            this.Ytverjdenia2 = new System.Windows.Forms.CheckBox();
            this.Ytverjdenia = new System.Windows.Forms.CheckBox();
            this.Otmete = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Napishiteabrr = new System.Windows.Forms.Label();
            this.Kondensator = new System.Windows.Forms.RadioButton();
            this.Registr = new System.Windows.Forms.RadioButton();
            this.Triger = new System.Windows.Forms.RadioButton();
            this.Vibor3 = new System.Windows.Forms.ComboBox();
            this.Vibor2 = new System.Windows.Forms.ComboBox();
            this.Vibor = new System.Windows.Forms.ComboBox();
            this.Vin4ester = new System.Windows.Forms.Label();
            this.Pzy = new System.Windows.Forms.Label();
            this.OZY = new System.Windows.Forms.Label();
            this.OsnYstr = new System.Windows.Forms.Label();
            this.UstSootvetstvie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Perehod
            // 
            this.Perehod.Location = new System.Drawing.Point(460, 300);
            this.Perehod.Name = "Perehod";
            this.Perehod.Size = new System.Drawing.Size(75, 23);
            this.Perehod.TabIndex = 37;
            this.Perehod.Text = "Далее";
            this.Perehod.UseVisualStyleBackColor = false;
            this.Perehod.Click += new System.EventHandler(this.Perehod_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(460, 257);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 23);
            this.Result.TabIndex = 36;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Ytverjdenia3
            // 
            this.Ytverjdenia3.AutoSize = true;
            this.Ytverjdenia3.Location = new System.Drawing.Point(5, 394);
            this.Ytverjdenia3.Name = "Ytverjdenia3";
            this.Ytverjdenia3.Size = new System.Drawing.Size(488, 17);
            this.Ytverjdenia3.TabIndex = 35;
            this.Ytverjdenia3.Text = "Если модули памяти имеют разную частоту,то память будет работать по меньшей часто" +
    "те";
            this.Ytverjdenia3.UseVisualStyleBackColor = true;
            // 
            // Ytverjdenia2
            // 
            this.Ytverjdenia2.AutoSize = true;
            this.Ytverjdenia2.Location = new System.Drawing.Point(5, 370);
            this.Ytverjdenia2.Name = "Ytverjdenia2";
            this.Ytverjdenia2.Size = new System.Drawing.Size(284, 17);
            this.Ytverjdenia2.TabIndex = 34;
            this.Ytverjdenia2.Text = "Чем выше частота, тем производительнее память";
            this.Ytverjdenia2.UseVisualStyleBackColor = true;
            // 
            // Ytverjdenia
            // 
            this.Ytverjdenia.AutoSize = true;
            this.Ytverjdenia.Location = new System.Drawing.Point(5, 346);
            this.Ytverjdenia.Name = "Ytverjdenia";
            this.Ytverjdenia.Size = new System.Drawing.Size(290, 17);
            this.Ytverjdenia.TabIndex = 33;
            this.Ytverjdenia.Text = "Модули памяти обязаны иметь одинаковую частоту";
            this.Ytverjdenia.UseVisualStyleBackColor = true;
            // 
            // Otmete
            // 
            this.Otmete.AutoSize = true;
            this.Otmete.Location = new System.Drawing.Point(5, 310);
            this.Otmete.Name = "Otmete";
            this.Otmete.Size = new System.Drawing.Size(190, 13);
            this.Otmete.TabIndex = 32;
            this.Otmete.Text = "Отметьте все верные утверждения:";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(2, 273);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(100, 20);
            this.Vvod.TabIndex = 31;
            // 
            // Napishiteabrr
            // 
            this.Napishiteabrr.AutoSize = true;
            this.Napishiteabrr.Location = new System.Drawing.Point(2, 225);
            this.Napishiteabrr.Name = "Napishiteabrr";
            this.Napishiteabrr.Size = new System.Drawing.Size(285, 26);
            this.Napishiteabrr.TabIndex = 30;
            this.Napishiteabrr.Text = "Напишите аббревиатуру (англ.),означающую память с \r\nпроизвольным доступом";
            // 
            // Kondensator
            // 
            this.Kondensator.AutoSize = true;
            this.Kondensator.Location = new System.Drawing.Point(257, 171);
            this.Kondensator.Name = "Kondensator";
            this.Kondensator.Size = new System.Drawing.Size(91, 17);
            this.Kondensator.TabIndex = 29;
            this.Kondensator.TabStop = true;
            this.Kondensator.Text = "Конденсатор";
            this.Kondensator.UseVisualStyleBackColor = true;
            // 
            // Registr
            // 
            this.Registr.AutoSize = true;
            this.Registr.Location = new System.Drawing.Point(257, 125);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(66, 17);
            this.Registr.TabIndex = 28;
            this.Registr.TabStop = true;
            this.Registr.Text = "Регистр";
            this.Registr.UseVisualStyleBackColor = true;
            // 
            // Triger
            // 
            this.Triger.AutoSize = true;
            this.Triger.Location = new System.Drawing.Point(257, 87);
            this.Triger.Name = "Triger";
            this.Triger.Size = new System.Drawing.Size(66, 17);
            this.Triger.TabIndex = 27;
            this.Triger.TabStop = true;
            this.Triger.Text = "Триггер";
            this.Triger.UseVisualStyleBackColor = true;
            // 
            // Vibor3
            // 
            this.Vibor3.FormattingEnabled = true;
            this.Vibor3.Items.AddRange(new object[] {
            "Оперативная память",
            "Постоянная память",
            "Внешняя память"});
            this.Vibor3.Location = new System.Drawing.Point(68, 168);
            this.Vibor3.Name = "Vibor3";
            this.Vibor3.Size = new System.Drawing.Size(121, 21);
            this.Vibor3.TabIndex = 26;
            // 
            // Vibor2
            // 
            this.Vibor2.FormattingEnabled = true;
            this.Vibor2.Items.AddRange(new object[] {
            "Оперативная память",
            "Постоянная память",
            "Внешняя память"});
            this.Vibor2.Location = new System.Drawing.Point(68, 129);
            this.Vibor2.Name = "Vibor2";
            this.Vibor2.Size = new System.Drawing.Size(121, 21);
            this.Vibor2.TabIndex = 25;
            // 
            // Vibor
            // 
            this.Vibor.FormattingEnabled = true;
            this.Vibor.Items.AddRange(new object[] {
            "Оперативная память",
            "Постоянная память",
            "Внешняя память"});
            this.Vibor.Location = new System.Drawing.Point(68, 87);
            this.Vibor.Name = "Vibor";
            this.Vibor.Size = new System.Drawing.Size(121, 21);
            this.Vibor.TabIndex = 24;
            // 
            // Vin4ester
            // 
            this.Vin4ester.AutoSize = true;
            this.Vin4ester.Location = new System.Drawing.Point(-1, 168);
            this.Vin4ester.Name = "Vin4ester";
            this.Vin4ester.Size = new System.Drawing.Size(60, 13);
            this.Vin4ester.TabIndex = 23;
            this.Vin4ester.Text = "Винчестер";
            // 
            // Pzy
            // 
            this.Pzy.AutoSize = true;
            this.Pzy.Location = new System.Drawing.Point(-1, 129);
            this.Pzy.Name = "Pzy";
            this.Pzy.Size = new System.Drawing.Size(30, 13);
            this.Pzy.TabIndex = 22;
            this.Pzy.Text = "ПЗУ";
            // 
            // OZY
            // 
            this.OZY.AutoSize = true;
            this.OZY.Location = new System.Drawing.Point(-1, 86);
            this.OZY.Name = "OZY";
            this.OZY.Size = new System.Drawing.Size(30, 13);
            this.OZY.TabIndex = 21;
            this.OZY.Text = "ОЗУ";
            // 
            // OsnYstr
            // 
            this.OsnYstr.AutoSize = true;
            this.OsnYstr.Location = new System.Drawing.Point(295, 32);
            this.OsnYstr.Name = "OsnYstr";
            this.OsnYstr.Size = new System.Drawing.Size(123, 26);
            this.OsnYstr.TabIndex = 20;
            this.OsnYstr.Text = "Основное устройство \r\nдинамической памяти:";
            // 
            // UstSootvetstvie
            // 
            this.UstSootvetstvie.AutoSize = true;
            this.UstSootvetstvie.Location = new System.Drawing.Point(-1, 32);
            this.UstSootvetstvie.Name = "UstSootvetstvie";
            this.UstSootvetstvie.Size = new System.Drawing.Size(130, 26);
            this.UstSootvetstvie.TabIndex = 19;
            this.UstSootvetstvie.Text = "Установите правильное\r\n соответствие:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 461);
            this.Controls.Add(this.Perehod);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Ytverjdenia3);
            this.Controls.Add(this.Ytverjdenia2);
            this.Controls.Add(this.Ytverjdenia);
            this.Controls.Add(this.Otmete);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Napishiteabrr);
            this.Controls.Add(this.Kondensator);
            this.Controls.Add(this.Registr);
            this.Controls.Add(this.Triger);
            this.Controls.Add(this.Vibor3);
            this.Controls.Add(this.Vibor2);
            this.Controls.Add(this.Vibor);
            this.Controls.Add(this.Vin4ester);
            this.Controls.Add(this.Pzy);
            this.Controls.Add(this.OZY);
            this.Controls.Add(this.OsnYstr);
            this.Controls.Add(this.UstSootvetstvie);
            this.MaximumSize = new System.Drawing.Size(576, 500);
            this.MinimumSize = new System.Drawing.Size(576, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Perehod;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.CheckBox Ytverjdenia3;
        private System.Windows.Forms.CheckBox Ytverjdenia2;
        private System.Windows.Forms.CheckBox Ytverjdenia;
        private System.Windows.Forms.Label Otmete;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Label Napishiteabrr;
        private System.Windows.Forms.RadioButton Kondensator;
        private System.Windows.Forms.RadioButton Registr;
        private System.Windows.Forms.RadioButton Triger;
        private System.Windows.Forms.ComboBox Vibor3;
        private System.Windows.Forms.ComboBox Vibor2;
        private System.Windows.Forms.ComboBox Vibor;
        private System.Windows.Forms.Label Vin4ester;
        private System.Windows.Forms.Label Pzy;
        private System.Windows.Forms.Label OZY;
        private System.Windows.Forms.Label OsnYstr;
        private System.Windows.Forms.Label UstSootvetstvie;
    }
}

