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


        //функция
        public static int ReplaceName(int c,int a, int b)
        {
                        
                if (c == a)
                c= b;                                
            
            return c;
        }
        //


        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {   MessageBox.Show("Заполните все поля!", "Ошибка");
                return; }
            
            textBox2.Text = "";
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                try
                {
                    textBox2.Text += Convert.ToString(ReplaceName(Convert.ToInt32(textBox1.Lines[i]), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text))) + Environment.NewLine;
                }

                catch
                {
                    textBox2.Text = "";
                    MessageBox.Show("Введите целые числа!\nПроверьте, чтобы не было пустых строк!", "Ошибка");
                    return;
                }
            }

        }
    }
}
