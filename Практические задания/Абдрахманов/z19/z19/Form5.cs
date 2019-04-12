using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z19
{
    public partial class Form5 : Form
    {
        int dx = 0;
        int dy = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Photo.Left = 150;
            Photo.Top = 100;
            dx = 1;	//на сколько изменяем положение по горизонтали
            dy = 0;	// на сколько изменяем положение по вертикали

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Photo.Left = Photo.Left + dx;
            Photo.Top = Photo.Top + dy;
            if ((Photo.Left == 0) || (Photo.Left == Width - Photo.Width)) dx = -dx;
            if ((Photo.Top == 0) || (Photo.Top == Height - Photo.Height)) dy = -dy;


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dy = 1;
            dx = 0;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dy = -1;
            dx = 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dy = 0;
            dx = -1;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dx = -1;
            dy = 1;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dy = -1;
            dx = 1;

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            dy = -1;
            dx = -1;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dy = 0;
            dx = 1;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dx = 1;
            dy = 1;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
