using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vvod4isla.Text = "3,4";
            Vvod4isla2.Text = "0,74";
            Vvod4isla3.Text = "19,43";
        }

        private void Vipolnit_Click(object sender, EventArgs e)
        {
            VivodResulta.Text +=  "Лаб.раб N1.Пкс-351 Абдрахманов Ж.З.";
            double x = double.Parse(Vvod4isla.Text);
            VivodResulta.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(Vvod4isla2.Text);
            VivodResulta.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(Vvod4isla3.Text);
            VivodResulta.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Tan(x + y) * Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x*x) + Math.Sin(z*z));
            double u = a -b * c;
            VivodResulta.Text += Environment.NewLine + "Результат U =" + u.ToString();
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();

        }
    }
}
