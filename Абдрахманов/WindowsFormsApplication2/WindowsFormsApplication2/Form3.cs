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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Vipolnit_Click(object sender, EventArgs e)
        {
            Inform.Text += "Лаб.раб N1.Пкс-351 Абдрахманов Ж.З.";
            double x = double.Parse(Vvod4isla.Text);
            Inform.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(Vvod4isla2.Text);
            Inform.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(Vvod4isla3.Text);
            Inform.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Pow(Math.Sqrt(8 + Math.Pow(Math.Abs(x - y),2) + 1),1/3);
            double b = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;
            double c = Math.Exp(Math.Abs(x - y));
            double d = Math.Pow(Math.Tan(z) * Math.Tan(z) +1,x);
            double u = a / b - c * d;
            Inform.Text += Environment.NewLine + "Результат U =" + u.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Vvod4isla.Text = "-4,5";
            Vvod4isla2.Text = "0,00075";
            Vvod4isla3.Text = "84,5";
        }
    }
}
