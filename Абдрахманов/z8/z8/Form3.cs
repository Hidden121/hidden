using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void времяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThTime = ThToday.ToLongTimeString();
            this.Time.Text = ThTime;

        }

        private void числоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.Date.ToLongDateString();
            this.Chislo.Text = ThData;

        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            z8.Form4 f = new z8.Form4();
            f.Show();
        }
    }
}
