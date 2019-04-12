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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Fibonachii_Click(object sender, EventArgs e)
        {
            int N = int.Parse(Vvod.Text);
            int C = 0;
            int A = 1;
            int B = 1;
            C = A + B;
            if ((Vvod.Text == "") || (N < 3))
            {
                MessageBox.Show("Введите число, большее 2");
            }
            else
            {
                for (int i = 3; i < N; i++)
                {
                    A = B;
                    B = C;
                    C = A + B;
                }
                Otvet.Text = C.ToString();


            }
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
