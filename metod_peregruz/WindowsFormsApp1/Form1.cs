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

       int c_1;
       string c_2;

        public Form1()
        {
            InitializeComponent();
        }          
                       
        
            public void AddAndDisplay(int a, int b) // объявление метода
        {
                c_1=a+b;
            }

            public void AddAndDisplay(string a, string b) // объявление метода
        {
                c_2=a+b;
            }


        private void button1_Click(object sender, EventArgs e)
        {
            AddAndDisplay(textBox2.Text, textBox3.Text); //вызов метода
            textBox1.Text = c_2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAndDisplay(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text)); //вызов метода
            textBox1.Text =Convert.ToString(c_1);
            
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Метод добавляет аргументы друг к другу и выводит результат (с числами это обычное сложение, с символами объединение в строку)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;  //установление значения combobox'ов по умолчанию
            comboBox2.SelectedIndex = 0;
        }
    }
}
