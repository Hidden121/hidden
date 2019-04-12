using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z20
{
    public partial class Form1 : Form
    {
        string[] phone = new string[5];
        string[] people = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phone[0] = "896045678";
            phone[1] = "896545678";
            phone[2] = "891255511";
            phone[3] = "890855511";
            phone[4] = "890322511";

            people[0] = "Иванов";
            people[1] = "Петров";
            people[2] = "Сидоров";
            people[3] = "Путилов";
            people[4] = "Минин";

        }

        private void Start_Click(object sender, EventArgs e)
        {
            String a = Vvod.Text; 	// читаем маску поиска
            Info.Items.Clear();	// обнуляем список
            for (int i = 0; i < 5; i++)	// перебираем элементы массива
            {
                if (phone[i].StartsWith(a) == true) Info.Items.Add(people[i]);
            }

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            String a = Vvod.Text; 	// читаем маску поиска
            Info.Items.Clear();	// обнуляем список
            for (int i = 0; i < 5; i++)	// перебираем элементы массива
            {
                if (phone[i].EndsWith(a) == true) Info.Items.Add(people[i]);
            }
        }

        private void Nomer_Click(object sender, EventArgs e)
        {
            String a = Vvod.Text; 	// читаем маску поиска
            Info.Items.Clear();	// обнуляем список
            for (int i = 0; i < 5; i++)	// перебираем элементы массива
            {
                if (phone[i].Contains(a) == true) Info.Items.Add(people[i]);
            }
        }

        private void Znakomstvo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
