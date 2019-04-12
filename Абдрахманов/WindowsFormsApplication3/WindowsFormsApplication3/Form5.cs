using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Glavnai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Obnulenia_Click(object sender, EventArgs e)
        {
            Vvod.Text = "";
            Vvodchisla.Text = "";
           
        }

        private void Treygolnik_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(Vvod.Text);
                double b = double.Parse(Vvod.Text);
                double z = a * 0.5 * a * b;
                Result.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }

        }

        private void Kvadrat_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(Vvod.Text);
                double b = double.Parse(Vvod.Text);
                double z = a * 4;
                Result.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }
        }
    }
}
