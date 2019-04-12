using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void KnopkaPerevodavinfi2_Click(object sender, EventArgs e)
        {
            string prep = "0123456789";

            int k = 0;

            int ind = OknoInfi.SelectedIndex;

            string str = (string)OknoInfi.Items[ind];

            int len = str.Length;

            char c;
            for (int i = 0; i < len; i++)
            {
                c = str[i];
                k = prep.IndexOf(c);
                if (k >= 0)
                {
                    OknoInfi2.Items.Add(c.ToString());
                }
            }
        }

        private void KnopkaDobavleniaTexta_Click(object sender, EventArgs e)
        {
            if (Vvodtexta.Text != " ")
            {
                OknoInfi.Items.Add(Vvodtexta.Text);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}


