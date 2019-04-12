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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            try
            {
                int S = 0;
                int Ost = 0;
                int A = int.Parse(Vvod.Text);
                int R = A;
                do
                {
                    Ost = R % 10;
                    S = S +  Ost;
                    R = R / 10;
                }
                while (R != 0);
                Otvet.Text = Convert.ToString(S);

            }
            catch
            {
                MessageBox.Show("Error");
            }
              
        }
    }
}
