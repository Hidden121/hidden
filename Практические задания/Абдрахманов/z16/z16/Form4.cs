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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Ras4itat_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(Vvod.Text);
                Okno.Items.Clear();
                for (int i = 2; i <= N / 2; i++)
                {
                    if (N % i == 0)
                        Okno.Items.Add(i);
                }
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
