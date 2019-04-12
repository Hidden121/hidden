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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Kolvonylei_Click(object sender, EventArgs e)
        {
            
            int index = OknoInfi.SelectedIndex;
            string str = (string)OknoInfi.Items[index];
            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '0')
                    count++;
                i++;
            }
            
            Vivod.Text = "Кол-во нулей= " + count.ToString();
           
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void KolvoEdinic_Click(object sender, EventArgs e)
        {
            int index = OknoInfi.SelectedIndex;
            string str = (string)OknoInfi.Items[index];
            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '1')
                    count++;
                i++;
            }
            Vivod2.Text = "Кол-во единиц =" + count.ToString();
        }

        private void KnopkaDobavlenia_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                OknoInfi.Items.Add(textBox1.Text);
            }
        }
        }
    }

