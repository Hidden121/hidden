using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace z7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void O4istit_Click(object sender, EventArgs e)
        {
            Vvodtexta.Text = "";
        }

        private void Zapisat_Click(object sender, EventArgs e)
        {
            string Text = Vvodtexta.Text;
            File.AppendAllText("new_file.txt", Text);

        }

        private void Pro4itat_Click(object sender, EventArgs e)
        {
            VivodResultata.Text = File.ReadAllText("new_file.txt");
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
