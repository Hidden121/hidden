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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Funkci_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form2 f = new Form2();
            f.Show();      // Открываем 2-ю форму
        }

        private void MeriDlini_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form3 f = new Form3();
            f.Show();      // Открываем 3-ю форму
        }

        private void MeriVesa_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form4 f = new Form4();
            f.Show();      // Открываем 4-ю форму
        }

        private void PloshadFigur_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form5 f = new Form5();
            f.Show();      // Открываем 4-ю форму
        }
    }
}
