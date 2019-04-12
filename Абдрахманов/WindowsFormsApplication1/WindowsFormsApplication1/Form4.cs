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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void KolvoCifr_Click(object sender, EventArgs e)
        {

                string prep = "0123456789";
                int k = 0;
                int m = 0;
                int i;
                int ind = OknoInfi.SelectedIndex;
                string str = (string)OknoInfi.Items[ind];
                int len = str.Length;
                char c;
                for (i = 0; i < len; i++)
                {
                    c = str[i];           
                    k = prep.IndexOf(c);
                    if (k > 0)
                    { m++; }
                }
                Vivod.Text = "Кол-во цифр=" + m.ToString();        
        }
        private void Perehod_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
        private void KnopkaDobaleniaTexta_Click(object sender, EventArgs e)
        {
            if (OknoTexta.Text != " ")
            {
                OknoInfi.Items.Add(OknoTexta.Text);
            }
        }

        private void OknoInfi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
