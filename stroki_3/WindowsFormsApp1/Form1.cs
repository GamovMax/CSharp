using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            string s;


            s = textBox1.Text;
            s = s.ToLower();
            string[] ar_1 = s.Split(',');

            try
            {
                label1.Text = ar_1[0];
                label2.Text = ar_1[1];
                label3.Text = ar_1[2];
                label4.Text = ar_1[3];
            }

            catch
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";

                MessageBox.Show("Должно быть не меньше четырех слов, разделенных запятой", "Ошибка");
                return;
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дана строка, которая содержит имена пользователей, разделенные запятой – 'Login1, LOgin2, login3, loGin4'." + Environment.NewLine + " Необходимо разбить эту строку на массив строк (чтобы отдельно были логины), и перевести их все в нижний регистр" + Environment.NewLine + "Символ, по которому будет разбита строка - запятая" + Environment.NewLine + "Выводится первые четыре слова", "О программе");
        }
    }
}
