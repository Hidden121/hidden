using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z7
{
    public partial class Form3 : Form
    {
        string[] author = { "Лушпин Евгений", "Ясенева Светлана", "Базанова Елена", "Павлова Мария", "Капустина Елена" };
        string[] name_k = { "Вечер в Венеции", " Старгородская площадь", "Сирень", "Вечер", "Ангел" };
        string[] pict = { "image/1.jpg", "image/2.jpg", "image/3.jpg", "image/4.jpg", "image/5.jpg" };
        string[] cena = { "15000", "9600", "12000", "10200", "11800" };
        int k = 0; 

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            VvodTexta.Text = author[k];
            Naim.Text = name_k[k];
            Chena.Text = cena[k];
            Photo.ImageLocation = pict[k];

        }

        private void Knopka_Click(object sender, EventArgs e)
        {
            k++;
            if (k > 4) k = 0;
            VvodTexta.Text = author[k];
            Naim.Text = name_k[k];
            Chena.Text = cena[k];
            Photo.ImageLocation = pict[k];

        }

        private void Knopka2_Click(object sender, EventArgs e)
        {
            k++;
            if (k > 4) k = 4;
            VvodTexta.Text = author[k];
            Naim.Text = name_k[k];
            Chena.Text = cena[k];
            Photo.ImageLocation = pict[k];
        }
    }
}
