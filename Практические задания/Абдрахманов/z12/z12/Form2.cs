using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Nod_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(Vvod.Text);
                int y = Convert.ToInt16(Vvod2.Text);
                while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
                
            }
                Vivod.Text = Convert.ToString(x);

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Poehalidalshie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
