using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Обязательно прописываем для работы с файлами
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled =false;

            string[] s = new string[5] { "red", "green", "black", "white", "blue"};

            //создаем файловый поток
            FileStream file1 = new FileStream("colors.txt", FileMode.Create);

            //создаем «потоковый писатель» и связываем его с файловым потоком
            StreamWriter writer = new StreamWriter(file1);

            for (byte i = 0; i < 5; i++)
            {
                writer.WriteLine(s[i]); //записываем в файл
            }


                //закрываем поток. Не закрыв поток, в файл ничего не запишется
                writer.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создаёт файл colors.txt и записывает элементы" + Environment.NewLine + "массива ('red', 'green', 'black', 'white', 'blue') построчно", "О программе");
        }
    }
}
