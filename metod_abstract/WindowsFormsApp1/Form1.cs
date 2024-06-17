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
            
            label1.Text ="";

            List<Person> persons = new List<Person>();  // создаем список указателей на базовый класс
            
            persons.Add(new Student(textBox3.Text, textBox4.Text, textBox5.Text));// добавление в список
            persons.Add(new Pupil(textBox6.Text, textBox7.Text, textBox8.Text));

            foreach (Person p in persons)
            {
                p.ShowInfo(); //вызов метода
                label1.Text += p.str + Environment.NewLine;
            }           

        }

        abstract class Person // объявление абстрактного базового класса
        {

            public string str{ get; set; }  //объявление автоматических свойств, которые в дальнейшем наследуются в классах наследниках
            public string Name { get; set; }  
            public string Age { get; set; }  

            public abstract void ShowInfo(); //объявление абстрактного метода, который в базовом классе не может иметь реализацию

        }


        class Student : Person // объявление класса наследника
        {
            
            public string HighSchoolName { get; set; }  //объявление автоматического свойства

            public Student(string name, string age, string hsName) //объявление конструктора
            {
                Name = name; //присваиваем значения автоматическим свойствам
                Age = age;
                HighSchoolName = hsName;
            }
            public override void ShowInfo() // реализация абстрактного метода
            {
                //присваиваем значение автоматическому свойству
                str = "Студент" + Environment.NewLine + Environment.NewLine + "Имя: " + Name + Environment.NewLine + "Возраст: " + Age + Environment.NewLine + "Вуз: " + HighSchoolName + Environment.NewLine;
            }
        }


        class Pupil : Person // объявление класса наследника
        {
            public string klass { get; set; }  //объявление автоматического свойства

            public Pupil(string name, string age, string kl) //объявление конструктора

            {
                Name = name; //присваиваем значения автоматическим свойствам
                Age = age;
                
                klass = kl;
            }
            public override void ShowInfo() // реализация абстрактного метода
            {
                //присваиваем значение автоматическому свойству
                str = "Школьник" + Environment.NewLine + Environment.NewLine + "Имя: " + Name + Environment.NewLine + "Возраст: " + Age + Environment.NewLine + "Класс: " + klass;
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Есть абстрактный класс Человек, и от него наследуются еще два – Студент и Школьник. В базовом классе есть абстрактный метод ShowInfo. В классах Студент и Школьник этот абстрактный метод реализуется для того, чтобы вывести информацию, относящуюся к соответствующему классу.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
