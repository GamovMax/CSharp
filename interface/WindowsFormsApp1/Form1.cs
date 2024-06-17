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
            TV tv1 = new TV(); //создание объекта

            if (button1.Text == "Включить TV")
            { tv1.Vikl(); // вызов метода
                button1.Text = tv1.str; //обращение к полю объекта
            }
            else
            {
                tv1.Vkl(); // вызов метода
                button1.Text = tv1.str; //обращение к полю объекта
            }
        }
                
        interface IVkl_Vikl // объявление интерфейса
        {
            void Vkl(); // метод
            void Vikl(); // метод
        }
        class TV : IVkl_Vikl //реализация интерфейса
        {
            public string str; //объявление поля

            public void Vkl() //реализация метода
            {
                str ="Включить TV";
            }

            public void Vikl() //реализация метода
            {
                str = "Выключить TV";
            }
                        
        }
        class DVD : IVkl_Vikl //реализация интерфейса
        {
            public string str; //объявление поля

            public void Vkl() //реализация метода
            {
                str = "Включить DVD";
            }

            public void Vikl() //реализация метода
            {
                str = "Выключить DVD";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DVD dvd1 = new DVD(); //создание объекта

            if (button2.Text == "Включить DVD")
            {
                dvd1.Vikl(); // вызов метода
                button2.Text = dvd1.str; //обращение к полю объекта
            }
            else
            {
                dvd1.Vkl(); // вызов метода
                button2.Text = dvd1.str; //обращение к полю объекта
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Создайте интерфейс, в котором объявите два метода – включение и выключение. Придумайте и создайте два класса, которые будут реализовывать этот интерфейс.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
