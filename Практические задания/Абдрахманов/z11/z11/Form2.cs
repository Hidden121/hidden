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
    public partial class Form2 : Form
    {
        static public int Hislo;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Zadatchislo_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Hislo = rand.Next(0, 100);
            MessageBox.Show("Загаданно новое число");
        }

        private void Surrender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Hislo.ToString());
        }

        private void Vvod_Click(object sender, EventArgs e)
        {

            if (Vvodchisla.Text !="") 
            {
                int a = int.Parse(Vvodchisla.Text);  
                if (Hislo > a) 
                    {
                    MessageBox.Show ("Число больше загаданного");
                    };
                if (Hislo == a) 
                    {
                    MessageBox.Show ("Угадали!");
                    };
                if (Hislo < a) 
                    {
                    MessageBox.Show ("Число меньше загаданного");
                    };
            }
            else
            {
                MessageBox.Show ("Вы забыли ввести число");
            }

        }

        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
