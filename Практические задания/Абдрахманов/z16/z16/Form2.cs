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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Delmost2_Click(object sender, EventArgs e)
        {
            Okno.Items.Clear();
            int N1 = int.Parse(Vvod.Text);
            int N2 = int.Parse(Vvod2.Text);
            for (int i = N1; i <= N2; i++)
            {

                if (i % 2 == 0) 
                Okno.Items.Add(i);

            }
        }

        private void Delmost3_Click(object sender, EventArgs e)
        {
            Okno.Items.Clear();
            int N1 = int.Parse(Vvod.Text);
            int N2 = int.Parse(Vvod2.Text);
            for (int i = N1; i <= N2; i++)
            {

                if (i % 3 == 0)
                    Okno.Items.Add(i);

            }
        }

        private void Delmost5_Click(object sender, EventArgs e)
        {
            Okno.Items.Clear();
            int N1 = int.Parse(Vvod.Text);
            int N2 = int.Parse(Vvod2.Text);
            for (int i = N1; i <= N2; i++)
            {

                if (i % 5 == 0)
                    Okno.Items.Add(i);
            }
        }

        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();

        }
    }
}
