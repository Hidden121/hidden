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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                Okno.Items.Clear();
                Okno2.Items.Clear();

                int x = int.Parse(Vvod.Text);
                int y = int.Parse(Vvod2.Text);
                Random rand = new Random();
                int a, b = 0; // a – случайное число , b – его квадрат
                for (int i = 1; i <= 10; i++) //оформите запуск цикла 10 раз
                {
                    a = rand.Next(x, y); // оформите: вычисляем случайное число в диапазоне от  
                    // x до y
                    Okno.Items.Add(a); // выводим случайное число в listBox1
                    b = a * a;
                    Okno2.Items.Add(b);

                }
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }


        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
