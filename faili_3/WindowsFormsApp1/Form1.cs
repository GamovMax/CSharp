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

        

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Программа открывает файл file.txt и находит в нем самую длинную строку.", "О программе");
            }

        private void button1_Click(object sender, EventArgs e)
        {       

            string s = "", s_max = "";
            int max = 0;

            try
            { 
            //создаем файловый поток
            FileStream file1 = new FileStream("file.txt", FileMode.Open);

            //создаем «потоковый читатель» и связываем его с файловым потоком
            StreamReader reader = new StreamReader(file1);

            s = reader.ReadToEnd();

            if (String.IsNullOrEmpty(s))
            {
                label1.Text = "";
                textBox1.Text = "";
                MessageBox.Show("Файл file.txt пуст", "Ошибка");
                return;
            }

            s = "";

             reader.BaseStream.Position = 0;//возвращаем позицию в начало файла

            while (!reader.EndOfStream)
            {
                s = reader.ReadLine(); //читаем из файла

                if (s.Length > max)
                {
                    max = s.Length;
                    s_max = s;
                }

            }



            //закрываем поток. Не закрыв поток, в файл ничего не запишется
            reader.Close();
            label1.Text = "Количество символов в" + Environment.NewLine + "самой длинной строке:" + Environment.NewLine + max;
            textBox1.Text = s_max;}

            catch
            {
                label1.Text = "";
                textBox1.Text = "";
                MessageBox.Show("Ошибка при открытии файла!" + Environment.NewLine + "Возможно файла file.txt не существует", "Ошибка");
                return;
            }

        }
    }
    }

