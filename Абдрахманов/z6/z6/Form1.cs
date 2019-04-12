using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HashSet<string> music = new HashSet<string>();
        HashSet<string> dancing = new HashSet<string>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormirovanieGrupp_Click(object sender, EventArgs e)
        {
            Info.Items.Clear();
            music.Add("Иванов");
            music.Add("Петров");
            music.Add("Сидоров");
            music.Add("Курочкина");
            music.Add("Смирнова");
            music.Add("Пронина");
            music.Add("Коровкин");
            music.Add("Семенов");
            Info2.Items.Clear();
            dancing.Add("Сидоров");
            dancing.Add("Смирнова");
            dancing.Add("Коровкин");
            dancing.Add("Донцова");
            dancing.Add("Григорьев");
            foreach (string word in music)	// пока список music не исчерпан
            {
                Info.Items.Add(word);   // выведем значения из множества music в 1 список
            }
            foreach (string word in dancing)	// пока список dancing не исчерпан
            {
                Info2.Items.Add(word); // выведем значения из множества dancing во 2 список
            }

        }

        private void lubieKrujki_Click(object sender, EventArgs e)
        {
            var rezult = music.Union(dancing);	// объединяем множества
            Info3.Items.Clear();	// очищаем 3 список
            foreach (string word in rezult)	// пока список rezult не исчерпан
            {
                Info3.Items.Add(word);
            }

        }

        private void ObaKrujka_Click(object sender, EventArgs e)
        {
            var rezult = music.Intersect(dancing);	// находим пересечение множеств
            Info3.Items.Clear();
            foreach (string word in rezult)
            {
                Info3.Items.Add(word);
            }

        }

        private void TolikoMuzika_Click(object sender, EventArgs e)
        {
            var rezult = music.Except(dancing);	// находим пересечение множеств
            Info3.Items.Clear();
            foreach (string word in rezult)
            {
                Info3.Items.Add(word);
            }
        }

        private void TolikoTanci_Click(object sender, EventArgs e)
        {
            var rezult = dancing.Except(music);	// находим пересечение множеств
            Info3.Items.Clear();
            foreach (string word in rezult)
            {
                Info3.Items.Add(word);
            }
        }

        private void Kolvostudentovvmuzike_Click(object sender, EventArgs e)
        {
            music.Except(dancing);
            int count = music.Count();
            Kolvostudentovvkrujkemuziki.Text = "Кол-во студентов в кружке музыки: " + count.ToString();

        }

        private void Kolvostudentovvkrujketanci_Click(object sender, EventArgs e)
        {
                music.Except(dancing);
                int count = dancing.Count();
                Kolvostudentovvkrujkemuziki.Text = "Кол-во студентов в кружке танцы: " + count.ToString();
        }

        private void Tolko1krujok_Click(object sender, EventArgs e)
        {
            music.SymmetricExceptWith(dancing);	// находим пересечение множеств
            Info3.Items.Clear();
            foreach (string word in music)
            {
                Info3.Items.Add(word);
            }
            
        }

        private void Ukazaniistudent_Click(object sender, EventArgs e)
        {
            bool bfount = music.Contains(Info3.Text);
            Kolvostudentovvkrujkemuziki.Text = "Музыку посещает указанный студент:";
            if (music.Contains(napisattext.Text))
            {
                Kolvostudentovvkrujkemuziki.Text = "Музыку посещает указанный студент!!!";   
            }
            else
            {
                Kolvostudentovvkrujkemuziki.Text = "Музыку НЕ посещает указанный студент:";
            }
        }
        
    }
}
