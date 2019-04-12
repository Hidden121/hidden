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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Factorialchisla_Click(object sender, EventArgs e)
        {
            try
            {

                int F = 1;
                int S = Convert.ToInt16(Vvodchisla.Text);
                for (int K = 1; K <= S; K++)
                    F = F * K;
                Vivodchisla.Text = Convert.ToString(F);
            }
            catch
            {
                MessageBox.Show("Error");
            }
                
            }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
        }
  }
