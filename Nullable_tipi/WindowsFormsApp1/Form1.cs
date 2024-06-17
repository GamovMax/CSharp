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
            comboBox1.SelectedIndex = 0; //установление значения combobox'ов по умолчанию
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Создайте метод, который будет выводить информацию о количестве детей у человека. Метод принимает имя человека и количество (nullable). Метод должен выводить: неизвестно, нет детей и сообщение о количестве детей.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public class People //объявление класса
        {
            public string name { get; set; } //объявление свойства
            public int? kolich { get; set; } //объявление свойства


            public People(string name_1, int? kolich_1) //объявление конструктора
            {
                name = name_1;
                kolich = kolich_1;
            }                     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? a1;
            if (comboBox1.Text == "Не указывать")
            {
                a1 = null;
            } 
            else
            {
                a1 = Convert.ToInt32(comboBox1.Text);
            }

            People myPeople = new People(textBox1.Text, a1);//создание объкта класса People

            

            if(myPeople.kolich == null)
            label3.Text = "Имя: " + myPeople.name + Environment.NewLine + "Количество детей: неизвестно";

            else if(myPeople.kolich == 0)
            label3.Text = "Имя: " + myPeople.name + Environment.NewLine + "Количество детей: нет детей";

            else
            label3.Text = "Имя: " + myPeople.name + Environment.NewLine + "Количество детей: " + myPeople.kolich;

        }
    }
}
