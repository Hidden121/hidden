﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеШашкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            z8.Form2 f = new z8.Form2();
            f.Show();
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            z8.Form3 f = new z8.Form3();
            f.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
