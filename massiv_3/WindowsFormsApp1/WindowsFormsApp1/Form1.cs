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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле должно быть заполненно!", "Ошибка");
                return;
            }

            else
            { 
                textBox2.Text = "";

            //На каждой итерации в переменную el последовательно записывается элемент коллекции.
            foreach (string el in textBox1.Lines)
            {
                try
                {
                    if ((Convert.ToInt32(el) >= 20) && (Convert.ToInt32(el) <= 50))
                    { textBox2.Text += el + Environment.NewLine; }
                }
                catch
                {
                    textBox2.Text = "";
                    MessageBox.Show("Поле должно быть заполненно!\nНе должно быть пустых строк!\nДолжны быть целые числа!", "Ошибка");
                    return;
                }


            }

            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выводит во втором поле все числа первого поля, которые входят в диапазон от 20 до 50", "О программе");
        }
    }
}
