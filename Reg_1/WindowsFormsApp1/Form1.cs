using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Для того, чтобы работать с регулярными выражениями необходимо подключить в начале программы пространство имен using System.Text.RegularExpressions; 

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
            Regex myReg = new Regex("^[A-Za-z]{1}[A-Za-z0-9]{1,9}$");

            if (myReg.IsMatch(textBox1.Text))
                label1.Text ="Логин введен верно";
            else
                label1.Text = "Логин введен неверно";


        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Программа, которая проверяет корректность ввода логина. Корректным логином является строка от 2-х до 10-ти символов, содержащая только латинские буквы и цифры, и при этом цифра не может быть первым символом.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
