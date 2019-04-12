using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z22
{
    public partial class Form1 : Form
    {
        int kol_slov = 0;		// количество слов
        int[] D = new int[15];		// массив длин слов
        string[] Slovo = new string[15];	// массив слов
        int k = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Razdelit_Click(object sender, EventArgs e)
        {
            string a = Vvod.Text;
            string b = "";

        }

        private void KolvoSlov_Click(object sender, EventArgs e)
        {
            kol_slov = k + 1;
        }

        private void Samoedlinoeslovo_Click(object sender, EventArgs e)
        {
            int max = 0;
            string S = "";
            for (int i = 0; i < kol_slov; i++)
            {
                if (D[i] > max)
                {
                    max = D[i];
                    S = Slovo[i];
                }
            }
            label4.Text = S;

        }

        private void Naitislovo_Click(object sender, EventArgs e)
        {
            string a = Info.Text;
            int b = Vvod.Text.IndexOf(a) + 1;
            if (Vvod.Text.IndexOf(a) == -1)
            {
                Vvod3.Text = "не встречается";
            }
            else
            {
                Vvod3.Text = Convert.ToString(b);

            }
        }
    }
}
