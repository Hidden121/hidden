using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Vicheslit_Click(object sender, EventArgs e)
        {
            try
            {
                int D = 0;
                int A = 0;
                int N = int.Parse(Vvod.Text);
                int K = int.Parse(Vvod2.Text);
                {
                    D = N / K;
                    A = N % K;
                }
                Chastnoe.Text = Convert.ToString(D);
                Ostatok.Text = Convert.ToString(A);
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form2 f = new Form2();
            f.Show();      // Открываем 2-ю форму

        }
    }
}
