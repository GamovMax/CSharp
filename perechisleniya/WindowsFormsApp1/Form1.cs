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
        enum Directions {Meat=1, Bird, Fish, Mouse}; // объявление перечисления

        Cat myCat = new Cat(75); //создание объкта класса Cat


        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; //установление значения combobox'ов по умолчанию
            label1.Text = "Уровень сытости: " + myCat.sitost; //установление значения label1.Text по умолчанию
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Создайте класс Кошка. У кошки будет свойство «уровень сытости» и метод «съесть что-то». Создайте перечисление Еда (рыба, мышь…). Каждый вид еды должен по-разному изменять уровень сытости.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        public class Cat //объявление класса
        {
            public int sitost { get; set; } //объявление свойства
            

            public Cat(int sitost_1) //объявление конструктора
            {
                sitost = sitost_1;
            }

            public void est(int a) // объявление метода
            {
                sitost = sitost + a;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Мясо": //Если comboBox1.Text равно значению "Мясо", то выполняются следующие действия
                    myCat.est((int)Directions.Meat);// вызов метода
                    break;
                case "Птица":
                    myCat.est((int)Directions.Bird);
                    break;
                case "Рыба":
                    myCat.est((int)Directions.Fish);
                    break;
                case "Мышь":
                    myCat.est((int)Directions.Mouse);
                    break;
            }

           label1.Text = "Уровень сытости: " + myCat.sitost;

        }
    }
}
