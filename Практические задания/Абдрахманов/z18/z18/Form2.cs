using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z18
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (New.Left > Width) New.Left = -New.Width;
            New.Left = New.Left + 1;   //  выводим надпись с новой позиции

        }

        private void быстрееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Time.Interval = Time.Interval - 2;
                if (Time.Interval > 10) Time.Interval = Time.Interval - 10;
            }
            catch
            {
                MessageBox.Show("Куда летим?");
            }
        }

        private void Kontextmenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void медленнееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Time.Interval = Time.Interval + 2;
                if (Time.Interval > 10) Time.Interval = Time.Interval + 10;
            }
            catch
            {
                MessageBox.Show("Куда летим?");
            }
            
        }

        private void переходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
