using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Obnulenia_Click(object sender, EventArgs e)
        {
            Vvod4isla.Text = "";
            Result.Text = ""; 

        }

        private void Sin_Click(object sender, EventArgs e)
        {     
         try
            {
                double y = double.Parse(Vvod4isla.Text);
                double z = Math.Sin(y);
                Result.Text = z.ToString();
            }
        catch
            {
    DialogResult result = MessageBox.Show("Введите число");
        
            }

           
        }



        private void Cos_Click(object sender, EventArgs e)
        {
            try
            {
                double y = double.Parse(Vvod4isla.Text);
                double z = Math.Cos(y);
                Result.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }
            
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double y = double.Parse(Vvod4isla.Text);
                double z = Math.Sqrt(y);
                Result.Text = z.ToString();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Введите число");

            }
        }
    }
}
