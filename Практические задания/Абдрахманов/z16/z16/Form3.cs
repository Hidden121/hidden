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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Ras4itat_Click(object sender, EventArgs e)
        {
            Okno.Items.Clear();
            int A = int.Parse(Vvod.Text);
            int Ost = 0;
            int R = A;
            do
            {
                Ost = R % 10;
                Okno.Items.Add(Ost);
                R = R / 10;
            }
            while (R != 0);
            Okno.Text = Convert.ToString(R);


        }

        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form4 f = new Form4();
            f.Show();      // Открываем 2-ю форму
        }
    }
}
