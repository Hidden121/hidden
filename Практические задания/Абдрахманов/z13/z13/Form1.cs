using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Summa_Click(object sender, EventArgs e)
        {
            try
            {
                Okno.Items.Clear();
                Random rand = new Random();
                int a; // объявляем переменную для сохранения случайного числа
                int S = 0; // объявляем переменную для накопления суммы
                for (int i = 1; i <= 5; i++) // запускаем цикл 5 раз
                {
                    a = rand.Next(0, 10); // вычисляем случайное число в диапазоне от 0 до 10
                    Okno.Items.Add(a); // выводим случайное число в listBox1 на форму
                    S = a + S;//  добавляем случайное число к сумме
                }
                Otvet.Text = S.ToString(); // выводим результат
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
