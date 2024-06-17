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
        Student student1 = new Student();  //создание объекта student1 класса Student

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            student1.group = textBox1.Text;  //присваиваем полю объекта значение           
        }

        class Student //объявление класса (без указания модификатора доступа, класс будет internal)
        {
            public string group; //объявление поля
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = student1.group; //обращение к полю объекта
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заносит значение в 'student1.group'" + Environment.NewLine + "Выводит эначение 'student1.group'", "О программе"); //вывод окна "О программе"
        }
    }
}
