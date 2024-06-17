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

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Создается класс окружность с полями: координаты центра и радиус, и переопределяются в нем методы Equals и GetHashCode. Окружности равны если у них одинаковые координаты центра и радиусы.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ch_1, ch_2;
            

            try
            {
                ch_1 = Convert.ToInt32(textBox3.Text); //конвертирование из string в int и присваивание значения переменным
                ch_2 = Convert.ToInt32(textBox4.Text);
                
            }
            catch
            {
                label5.Text = "";
                label6.Text = "";
                MessageBox.Show("Все поля должны быть заполнены. Радиус должен быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Circle myCircle1 = new Circle(textBox1.Text, ch_1); //создание объктов класса
            Circle myCircle2 = new Circle(textBox2.Text, ch_2);


            if (myCircle1.Equals(myCircle2))
                label5.Text = "Окружности равны";
            else
                label5.Text = "Окружности неравны";
                  

            label6.Text = "Хэш код первой окружности: " + Convert.ToString(myCircle1.GetHashCode()) + Environment.NewLine + "Хэш код второй окружности: " + Convert.ToString(myCircle2.GetHashCode());
            
        }
    }

    public class Circle
    {
        public string Center { get; set; }
        public int Radius { get; set; }

        public Circle(string Center_in, int Radius_in)
        {
            Center = Center_in;
            Radius = Radius_in;
        }

        public override bool Equals(object obj_in)
        {
            if (obj_in == null)
                return false;

            Circle perem = obj_in as Circle;
            if (perem as Circle == null)
                return false;

            return perem.Center == this.Center && perem.Radius == this.Radius;
                         
        }

        public bool Equals(Circle obj_in_1) // аргумент типа Circle
        {
            if (obj_in_1 == null)
                return false;
            return obj_in_1.Center == this.Center && obj_in_1.Radius == this.Radius;
                       
        }

        public override int GetHashCode()
        {            
            return (int)Radius + 11;
        }

    }
       

    }
