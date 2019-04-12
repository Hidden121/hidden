using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z20
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Formirovat_Click(object sender, EventArgs e)
        {
            string SS;
            string S = "За отличные успехи в учебе почетной грамотой награждаются студенты: ";
            string A = "Иванов,Петров,Сидоров";
            string C = S + A;
            int k = Info.Items.Count;
            for (int i = 0; i < k; i++)
            {
                SS = (string)Info.Items[i];
            }
            Vivod.Text = C;
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}
