using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (Vibor.Text == "Оперативная память") sum = sum + 1;	//  увеличиваем сумму очков
            if (Vibor2.Text == "Постоянная память") sum = sum + 1;	//  увеличиваем сумму очков
            if (Vibor3.Text == "Внешняя память") sum = sum + 1;	//  увеличиваем сумму очков
            if (Kondensator.Checked) sum += 1;
            {
                String s;
                s = Vvod.Text.ToUpper();
                if (s == "RAM") sum += 1;
                if ((!(Ytverjdenia.Checked)) && (Ytverjdenia2.Checked) && (Ytverjdenia3.Checked)) sum += 1;

            }
            switch (sum)
            {
                case 6: MessageBox.Show("отлично "); break;
                case 5: MessageBox.Show("хорошо "); break;
                case 4: MessageBox.Show("хорошо "); break;
                case 3: MessageBox.Show("удовлетворительно "); break;
                case 2: MessageBox.Show("плохо "); break;
                default: MessageBox.Show("плохо "); break;
            }
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sledy f = new Sledy();
            f.Show();
        }
    }
}
