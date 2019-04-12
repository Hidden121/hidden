using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Ras4itat_Click(object sender, EventArgs e)
        {
            double rost = double.Parse(Vvodrosta.Text) / 100;      // Рост переводим в метры
            double ves = double.Parse(Vvodves.Text);   // Допишите самостоятельно чему равняется вес
            double ket = ves / (rost * rost);  // вычисляем коэффициент
            if (Mujskoi.Checked)
            {
                if ((ket >= 19) && (ket <= 25))

                    MessageBox.Show("Вес нормальный");
                else
                {
                    MessageBox.Show("Not good");
                }
                if (Jenski.Checked)
                {
                    if ((ket >= 19) && (ket <= 24))

                        MessageBox.Show("Вес нормальный");
                    else
                    {
                        MessageBox.Show("Not good");
                    }

                }
            }
        }
    }
}
