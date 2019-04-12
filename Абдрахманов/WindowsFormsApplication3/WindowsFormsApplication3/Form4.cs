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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Nazad_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Funti_Click(object sender, EventArgs e)
        {
            try
            { 
            double y = double.Parse(Vvodtexta.Text);
            double z = y*2.2046;
            Oknoresultata.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }

        }
    }
}
