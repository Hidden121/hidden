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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void KolvoSlov_Click(object sender, EventArgs e)
        {
            int index = ViborPredlojnia.SelectedIndex;
            string str = (string)ViborPredlojnia.Items[index];
            int len = str.Length;
            int count = 1;
            int i = 1;
            while (i < len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            VivodInfo.Text = "Количество слов = " +
                count.ToString();
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void KnopkaDobavlenia_Click(object sender, EventArgs e)
        {
            if (DobavleniaTexta.Text != " ")
            {
                ViborPredlojnia.Items.Add(DobavleniaTexta.Text);
            }
        }
    }
}
