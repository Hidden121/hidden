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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (Photo.Top > Height) Photo.Top = -Photo.Height;
            Photo.Top = Photo.Top + 1;   

        }
    }
}
