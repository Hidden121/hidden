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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Duim_Click(object sender, EventArgs e)
        {
            try
            {
                double y = double.Parse(Vvodtexta.Text);
                double z = y * 39.37;
                Oknovivoda.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Milia_Click(object sender, EventArgs e)
        {
            try
            {
                double y = double.Parse(Vvodtexta.Text);
                double z = y * 0.000621371;
                Oknovivoda.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }
        }
    }
}
