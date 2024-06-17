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
        public struct Okruj //объявление структуры
        {
            public decimal radius; //объявление поля

            public Okruj(decimal radius_1) //объявление конструктора
            {
                radius = radius_1;               
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal r_1, r_2, r_3, r_4, r_5,sred=0,min_raz=-1,min_radius=0,vrem=0;
                      
            

            //Okruj[] numbers = new Okruj[5];
            
            try
            {
                r_1 = Convert.ToDecimal(textBox1.Text);
                r_2 = Convert.ToDecimal(textBox2.Text);
                r_3 = Convert.ToDecimal(textBox3.Text);
                r_4 = Convert.ToDecimal(textBox4.Text);
                r_5 = Convert.ToDecimal(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Должны быть введены дробные или целые числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Okruj> figures = new List<Okruj>(); //Добавление элементов в список (создание объектов)
            figures.Add(new Okruj(r_1));
            figures.Add(new Okruj(r_2));
            figures.Add(new Okruj(r_3));
            figures.Add(new Okruj(r_4));
            figures.Add(new Okruj(r_5));

            foreach (Okruj f in figures) //Обращение к элементам списка в цикле
            {
                sred += f.radius;
            }

                sred=sred/5;


            foreach (Okruj f in figures) //Обращение к элементам списка в цикле
            {
                if (min_raz == -1)
                    if (f.radius > sred)
                        min_raz = f.radius - sred;
                    else if (f.radius < sred)
                        min_raz = sred - f.radius;
                    else
                    {
                        min_raz = 0;
                        min_radius = f.radius;
                        break;
                    }   

                if (f.radius>sred)
                {
                    vrem = f.radius - sred;

                    if (vrem < min_raz)
                    {
                        min_raz = vrem;
                        min_radius = f.radius;
                    }    
                }
                else if(f.radius < sred)
                {
                    vrem =  sred - f.radius;

                    if (vrem < min_raz)
                    {
                        min_raz = vrem;
                        min_radius = f.radius;
                    }
                }
                else
                {
                    min_raz = 0;
                    min_radius = f.radius;
                    break;
                }
                
            }

            label6.Text = "Среднее значение радиусов окружностей: " + Convert.ToString(sred) + Environment.NewLine + "Радиус максимально близкий к среднему значению радиусов окружностей: " + Convert.ToString(min_radius) + Environment.NewLine + "Разница между средним значением и радиусом: " + Convert.ToString(min_raz);
                                 
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Создайте программу, которая будет находить окружность (структура) у которой радиус максимально близкий к среднему значению радиусов окружностей из списка.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
