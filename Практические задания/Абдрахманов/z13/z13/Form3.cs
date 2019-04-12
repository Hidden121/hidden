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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        { 
            try
            {
            Okno.Items.Clear();
            Random rand= new Random();
            int x = int.Parse(Vvod.Text);
            int y = int.Parse(Vvod2.Text);
            int a;
            int K = 0;
            for (int i=1; i<=10;i++) // запускаем цикл 5 раз
            {
                a = rand.Next(x, y); // вычисляем случайное число в диапазоне от 0 до 10
                Okno.Items.Add(a); // выводим случайное число в listBox1 на форму
                if (a<0) 
                {
                    K+=1;
                }
            }
            Otvet.Text = K.ToString(); // выводим результат
        } 
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }
        }
    }

