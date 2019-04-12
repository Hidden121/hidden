using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Text = "";
        }
        private void заглавныеБуквыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Box.Text = Box.Text.ToUpper();
        }

        private void строчныеБуквыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text.ToLower();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void количествоСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String a = Box.Text; 
            int k = 0;
            int len = Box.Text.Length;
            for (int i = 0; i < len; i++)
            {
                if (a[i] == ' ') k++;
            }
            k++;
            Otvet.Text = k.ToString();

        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string a = Naiti.Text;
                int b = Box.Text.IndexOf(a) + 1;
                if (Box.Text.IndexOf(a) == -1)
                {
                    Otvet.Text = "не встречается";
                }       
            else
            {
                Otvet.Text = Convert.ToString(b);

            }
        }

        private void количествоСимволовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String a = Box.Text;
            int k = 0;
            int len = Box.Text.Length;
            for (int i = 0; i < len; i++)
            {
                if (a[i] != ' ') k++; ;
            }
            Otvet.Text = k.ToString();
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Box.Text;
                string b = Naiti.Text;
                string c = Zamena.Text;
                Otvet.Text = (string)a.Replace(b, c);
            }
            catch
            {
                MessageBox.Show("Введите шо ищём");
            }
        
        }
    }
}
