using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z5
{
    public partial class Form1 : Form
    {
        string[] model = { "ASUS P8H61-MX R2.0", "ASUS P8Z77-V LX Z77", "MSI K7T266 Pro2", "PSYA P2Z17-V JX Z54","SQS 23121-A" };
        string[] opisan = { "Материнская плата ASUS P8H61-MX R2.0, H61, Socket 1155, DDR3, mATX", "Материнская плата ASUS P8Z77-V LX, Z77, Socket 1155, DDR3, ATX", "Материнская плата MSI K7T266 Pro2, 217, Socket 1155, DDR3, ATX", "Материнская плата PSYA P2Z17-V JX, Z54, Socket 2155, DDR5, mATX", "Материнская плата SQS 23121-A, Socket 755, DDR3, mATX" };
        string[] artikul = { "349617", "303389", "143389", "174389", "6-4389" };
        string[] pict = { "1.jpg", "2.jpg", "3.jpg", "4.jpg","10.jpg" };
        string[] cena = { "1550", "3480", "1480", "5480","2980" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                ViborPlati.Items.Add(model[i]);
        }

        private void ViborPlati_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = ViborPlati.SelectedIndex; // запоминаем номер выбранного элемента
            VivodCeni.Text = cena[n];		// выводим информацию об этом элементе
            Artical.Text = artikul[n];
            Vivod.Text = opisan[n];
            Kartinka.ImageLocation = pict[n];
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            z5.Form2 f = new z5.Form2();
            f.Show();
        }
    }
}
