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
    public partial class Sledy : Form
    {
        public Sledy()
        {
            InitializeComponent();
        }

        private void O4enka_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (Vibor1.Checked) sum = sum + 1;
            if (Otvet2.Checked) sum = sum + 1;
            if (Otvet3.Checked) sum = sum + 1;
            if (Vibor.Text == "Сумматор") sum = sum + 1;	//  увеличиваем сумму очков
            if (Vibor2.Text =="Регистр") sum = sum + 1;	//  увеличиваем сумму очков
            if (Vibor3.Text =="Инвертор") sum = sum + 1;	//  увеличиваем сумму очков         
            {
                String s;
                s = VvodSlova2.Text.ToUpper();
                if (s == "ROM") sum += 1;
            }
            switch (sum)
            {
                case 7: Otvet.Text = ("отлично"); break;
                case 6: Otvet.Text = ("отлично"); break;
                case 5: Otvet.Text = ("хорошо"); break;
                case 4: Otvet.Text = ("удовлетворительно"); break;
                case 3: Otvet.Text = ("плохо"); break;
                default: Otvet.Text = ("плохо"); break;
            }
        }

        private void Vibor3vm_Enter(object sender, EventArgs e)
        {

        }
    }
}
