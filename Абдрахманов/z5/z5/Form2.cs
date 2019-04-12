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
    public partial class Form2 : Form
    {
        string[] model = { "Winsis WI-02", "Corsair Obsidian Series 550D", "SASV AS-01s", "OGGS ALQ-322","Budka-21" };
        string[] opisan = { "Корпус Winsis WI-02, Mini-ITX, 300вт, черный", "Корпус Corsair Obsidian Series 550D, Midi-Tower, ATX, черный", "Корпус SASV AS-01s, 500вт, ATX, черный", "Корпус OGGS ALQ-322, ATX, черный", "Корпус Budka-21, ATX, черный" };
        string[] artikul = { "459689", "3-41893", "843389", "074389", "354389" };
        string[] pict = { "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg" };
        string[] cena = { "3550", "4480", "5480", "6480", "100" };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                ViborKorpusa.Items.Add(model[i]);
        }

        private void ViborPlati_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = ViborKorpusa.SelectedIndex; // запоминаем номер выбранного элемента
            VivodCeni.Text = cena[n];		// выводим информацию об этом элементе
            Artical.Text = artikul[n];
            Opisanie.Text = opisan[n];
            Kartinka.ImageLocation = pict[n];
        }
    }
}
