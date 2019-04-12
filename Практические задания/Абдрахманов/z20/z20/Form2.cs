using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Privetstvie_Click(object sender, EventArgs e)
        {
            string a = Vvodimeni.Text;
            string b = "Добрый день, ";
            string c = "!";
            string d = b + a + c;
            Vivod.Text = d;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
