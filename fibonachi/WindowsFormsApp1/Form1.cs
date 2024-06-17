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

            if (textBox1.Text=="1")
            {
                label1.Text ="1";
                return;
            }

            if (textBox1.Text == "2")
            {
                label1.Text = "1";
                return;
            }

            ulong a,ch_1,ch_2,ch_3;

            try
            { a = Convert.ToUInt64(textBox1.Text); }
            catch
            {                
                MessageBox.Show("Введите целое число больше нуля", "Ошибка");
                return;
            }


            if (a == 0)
            {
                MessageBox.Show("Введите целое число больше нуля", "Ошибка");
                return;
            }

            ch_1 =1;
            ch_2=1;
            ch_3 = 0;
            
            for (ulong i =2;i<a;i++)
            {
                ch_3 =ch_1+ch_2;
                ch_1 = ch_2;
                ch_2 = ch_3;                
            }

            label1.Text = Convert.ToString(ch_3);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа возвращает указанный элемент ряда Фибоначчи." + Environment.NewLine + " Ряд Фибоначчи – это ряд, в котором каждый следующий элемент равен сумме двух предыдущих." + Environment.NewLine + " 1 1 2 3 5 8 13 21…" + Environment.NewLine + " Программа принимает порядковый номер элемента, и возвращает соответствующий элемент.", "О программе");
        }
    }
}
