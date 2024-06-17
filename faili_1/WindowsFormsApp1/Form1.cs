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
            button1.Enabled = false;

            string s="1";

            for(int i=2;i<=500;i++)
            { s += ","+Convert.ToString(i); }

            //создаем файловый поток
            FileStream file1 = new FileStream("numbers.txt", FileMode.Create);

            //создаем «потоковый писатель» и связываем его с файловым потоком
            StreamWriter writer = new StreamWriter(file1);

            //записываем в файл
            writer.Write(s); //записываем в файл

            //закрываем поток. Не закрыв поток, в файл ничего не запишется
            writer.Close();


        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создаёт файл numbers.txt и записывает" + Environment.NewLine + " в него натуральные числа от 1 до 500 через запятую.", "О программе");
        }
    }
}
