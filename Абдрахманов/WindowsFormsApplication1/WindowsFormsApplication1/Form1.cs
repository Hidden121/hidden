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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Zapustit_Click(object sender, EventArgs e)
        {
            int index = Okno.SelectedIndex;
            string str = (string)Okno.Items[index];
            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            VivodKolvoProbelov.Text = "Количество пробелов = " +
                count.ToString();
        }
        private void Perehod_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void KnopkaDobavlenia_Click(object sender, EventArgs e)
        {
            if (VvodTexta.Text != " ")
            {
                Okno.Items.Add(VvodTexta.Text);
            }
        }

        private void Okno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
