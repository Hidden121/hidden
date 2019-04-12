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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Ishtext_Click(object sender, EventArgs e)
        {

        }

        private void Smoollllllll_Click(object sender, EventArgs e)
        {
            Bolshbykvi.Text = Vvod.Text.ToLower();
        }

        private void Bolshiebykvi_Click(object sender, EventArgs e)
        {
            Bolshbykvi.Text = Vvod.Text.ToUpper();
        }

        private void Pohnali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();

        }
    }
}
