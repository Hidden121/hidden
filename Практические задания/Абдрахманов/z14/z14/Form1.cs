using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z14
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zapolnitmassiv_Click(object sender, EventArgs e)
        {
            Okno.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-10, 10);
                Okno.Items.Add(Mas[i]);
            }

        }

        private void Summaotricatelnih_Click(object sender, EventArgs e)
        {
            int S = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] < 0)
                {
                    S = S + Mas[i];
                }
            }
            string s1 = S.ToString(); Otvet.Text = s1;
        }

        private void Kolvokratnix3_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] % 3 == 0)
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;

        }

        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Kolvopolojchisel_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] > 0 )
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void KolvoOtrichatelnix_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] < 0)
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void Ravnihhyliu_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] == 0)
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void Summavsexslychchisel_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] != 0)
                {
                    K = K + Mas[i];

                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void Summachiselkratnihdvym_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] % 2 != 0)
                {
                    K = K + Mas[i];
                    
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void Kratnie_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Mas[i] % 4 == 0)
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void Kratnie5_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Mas[i] % 5 == 0)
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }

        private void Kratnie7_Click(object sender, EventArgs e)
        {
            int K = 0;
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] % 7 == 0)
                {
                    K = K + 1;
                }
            }
            string s2 = K.ToString(); Otvet2.Text = s2;
        }
        }
    }
