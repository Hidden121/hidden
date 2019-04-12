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
    public partial class Form2 : Form
    {
        int num_f;
        public Form2()
        {
            InitializeComponent();
        }
        private void ZagrizitFail_Click(object sender, EventArgs e)
        {
            OknoInfi.Text = File.ReadAllText("1.txt");
        }
        private void Vpered_Click(object sender, EventArgs e)
        {
            String put;  		//путь
            num_f = num_f + 1;       	//увеличиваем номер файла
            if (num_f == 6) num_f = 1;   	//у нас всего 5 файлов. Вместо 6-го файла повторяем загрузку 1-го
            string num = num_f.ToString();
            put = num + ".txt";
             OknoInfi.Text = File.ReadAllText(put, System.Text.Encoding.Default);

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            String put;  		//путь
            num_f = num_f - 1;       	//увеличиваем номер файла
            if (num_f == 0) num_f = 5;   	//у нас всего 5 файлов. Вместо 6-го файла повторяем загрузку 1-го
            string num = num_f.ToString();
            put = num + ".txt";
            OknoInfi.Text = File.ReadAllText(put, System.Text.Encoding.Default);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
