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
            circle cr_1 = new circle(textBox1.Text, textBox2.Text); //вызов конструктора с параметрами

            cr_1.nr_c(textBox5.Text); //вызов метода

            label1.Text = cr_1.cntr_1; //читаем свойство
            label2.Text = cr_1.dlin_1; //читаем свойство
            label5.Text = cr_1.nr_c_1; //читаем поле
        }

        private void button2_Click(object sender, EventArgs e)
        {
            triangle tr_1 = new triangle(textBox3.Text, textBox4.Text); //вызов конструктора с параметрами

            tr_1.nr_t(textBox6.Text); //вызов метода


            label3.Text = tr_1.cntr_1; //читаем свойство
            label4.Text = tr_1.pr_1; //читаем свойство
            label6.Text = tr_1.nr_t_1; //читаем поле
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполняется следующее задание:" + Environment.NewLine + Environment.NewLine + "Создайте базовый класс Геометрическая фигура, предусмотрите в нем общие поля/свойства, например координаты центра фигуры, с помощью конструктора должна быть возможность задать центр. На базе этого класса создайте два новых – Треугольник и Окружность. В этих классах должны быть свои особые поля, например радиус для окружности. В оба класса добавьте метод Нарисовать, в котором могла бы быть специфическая логика рисования фигуры. Создайте объекты треугольник и окружность.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class G_F
    {
        public string cntr_1 { get; set; } //объявление автоматического свойства

        public G_F(string cntr_2) //объявление конструктора
        {
            cntr_1 = cntr_2;
        }
    }


    class circle : G_F
    {
        public string nr_c_1=""; //объявление поля


        public string dlin_1 { get; set; } //объявление автоматического свойства


        public circle(string cntr_2, string dlin_2) : base(cntr_2) //объявление конструктора
        {
            dlin_1 = dlin_2;
        }

        public void nr_c(string ch_c) //объявление метода
        {
            nr_c_1 = ch_c;

        }
    }


    class triangle : G_F
    {
        public string nr_t_1 = ""; //объявление поля


        public string pr_1 { get; set; } //объявление автоматического свойства


        public triangle(string cntr_2, string pr_2) : base(cntr_2) //объявление конструктора
        {
            pr_1 = pr_2;
        }

        public void nr_t(string ch_t) //объявление метода
        {
            nr_t_1 = ch_t;

        }

    }

}
