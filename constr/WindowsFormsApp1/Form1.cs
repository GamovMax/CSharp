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
            
            Student newSt = new Student(textBox1.Text, textBox2.Text, comboBox1.Text); //вызов конструктора с параметрами           


            try
            { 
            if ((Convert.ToInt32(textBox2.Text) < 1) || (Convert.ToInt32(textBox2.Text) > 5))
            {

                    label7.Text = "";
                    label8.Text = "";
                    label9.Text = "";

                    MessageBox.Show("Номер курса должен быть от 1 до 5!", "Ошибка");
                    textBox2.Focus();
                    return;
            } }
            catch
            {
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";

                MessageBox.Show("Номер курса должен быть целым числом от 1 до 5!", "Ошибка");
                textBox2.Focus();
                return;
            }

            label7.Text = newSt.name;
            label8.Text = newSt.kurs;
            label9.Text = newSt.stipend;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student newSt = new Student(textBox4.Text, textBox5.Text); //вызов конструктора с параметрами 



            try
            {
                if ((Convert.ToInt32(textBox5.Text) < 1) || (Convert.ToInt32(textBox5.Text) > 5))
                {
                    label7.Text = "";
                    label8.Text = "";
                    label9.Text = "";

                    MessageBox.Show("Номер курса должен быть от 1 до 5!", "Ошибка");
                    textBox5.Focus();
                    return;
                }
            }
            catch
            {
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";

                MessageBox.Show("Номер курса должен быть целым числом от 1 до 5!", "Ошибка");
                textBox5.Focus();
                return;
            }

            label7.Text = newSt.name;
            label8.Text = newSt.kurs;
            label9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student newSt = new Student(textBox6.Text); //вызов конструктора с параметрами 

            label7.Text = newSt.name;
            label8.Text = "";
            label9.Text = "";
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заносит значения в класс 'Student'" + Environment.NewLine + "И выводит эначения класса 'Student'", "О программе");
        }
    }

    class Student
    {
        public string name;
        public string kurs;
        public string stipend;


        public Student(string name, string kurs, string stipend) //объявление конструктора
        {
            this.name = name;
            this.kurs = kurs;                    

            this.stipend = stipend;
        }

        public Student(string name, string kurs) //объявление конструктора
        {
            this.name = name;
            this.kurs = kurs;            
        }

        public Student(string name) //объявление конструктора
        {
            this.name = name;
        }

    }
}
