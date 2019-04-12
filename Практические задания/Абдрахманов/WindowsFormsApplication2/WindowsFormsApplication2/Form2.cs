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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {    
                Vvod4isla.Text = "14,26";
                Vvod4isla2.Text = "-1,22";
                Vvod4isla3.Text = "0,035";
        }

        private void Vipolnit_Click(object sender, EventArgs e)
        {
            Result.Text += "Лаб.раб N1.Пкс-351 Абдрахманов Ж.З.";
            double x = double.Parse(Vvod4isla.Text);
            Result.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(Vvod4isla2.Text);
            Result.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(Vvod4isla3.Text);
            Result.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = (2*Math.Cos(x - Math.PI/6));
            double b = 0.5 + Math.Sin(y) + Math.Sin(y);
            double c = 1 + (Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
            double t = a / b * c;
            Result.Text += Environment.NewLine + "Результат  t =" + t.ToString();
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
