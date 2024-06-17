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

            persons.Add(new Person(textBox1.Text, textBox2.Text)); // добавление в список
            persons.Add(new Student(textBox3.Text, textBox4.Text, textBox5.Text));
            persons.Add(new Pupil(textBox6.Text, textBox7.Text, textBox8.Text));

            foreach (Person p in persons)
            {
                p.ShowInfo(); //вызов метода
                label1.Text += p.str + Environment.NewLine;
            }
            

        }

        class Person
        {

            public string str{ get; set; }  //объявление автоматического свойства, которое в дальнейшем наследуется в классах наследниках
            public string Name { get; set; }  //объявление автоматического свойства
            public string Age { get; set; }  //объявление автоматического свойства

            public Person(string name, string age) //объявление конструктора
            {
                Name = name; //присваиваем значения автоматическим свойствам
                Age = age;
            }
            public virtual void ShowInfo() //объявление виртуального метода
            {
                //присваиваем значение автоматическому свойству
                str = "Человек" + Environment.NewLine + Environment.NewLine+ "Имя: " + Name + Environment.NewLine+"Возраст: " + Age + Environment.NewLine;
            }
        }


        class Student : Person
        {
            
            public string HighSchoolName { get; set; }  //объявление автоматического свойства

            public Student(string name, string age, string hsName)  //объявление конструктора
         : base(name, age)
            {
                HighSchoolName = hsName; //присваиваем значение автоматическому свойству
            }
            public override void ShowInfo() // переопределение метода
            {
                //присваиваем значение автоматическому свойству
                str = "Студент" + Environment.NewLine + Environment.NewLine + "Имя: " + Name + Environment.NewLine + "Возраст: " + Age + Environment.NewLine + "Вуз: " + HighSchoolName + Environment.NewLine;
            }
        }


        class Pupil : Person
        {
            public string klass { get; set; }  //объявление автоматического свойства

            public Pupil(string name, string age, string kl)  //объявление конструктора
         : base(name, age)
            {
                klass = kl; //присваиваем значение автоматическому свойству
            }
            public override void ShowInfo() // переопределение метода
            {
                //присваиваем значение автоматическому свойству
                str = "Школьник" + Environment.NewLine + Environment.NewLine + "Имя: " + Name + Environment.NewLine + "Возраст: " + Age + Environment.NewLine + "Класс: " + klass;
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Есть класс Человек, и от него наследуются еще два – Студент и Школьник. В базовом классе есть виртуальный метод ShowInfo, который выводит информацию об объекте. В классах Студент и Школьник этот метод переопределяется для того, чтобы к выводу базовой информации добавить еще специфическую, относящуюся к соответствующему классу", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
