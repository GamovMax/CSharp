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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Массивы", "2019");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if ((textBox1.Lines.Length!=10) || (textBox2.Lines.Length != 10))
                {
                MessageBox.Show("Должно быть введено 10 строк", "Ошибка");
                return;
                }
            else
            {
                int a = 0;

                for (byte i = 0; i < 10; i++)
                {
                    try
                    {
                        a = Convert.ToInt32(textBox1.Lines[i]) + Convert.ToInt32(textBox2.Lines[i]);
                    }
                    catch
                    {
                        textBox3.Text = "";
                        MessageBox.Show("Поля должны быть заполнены полностью!\nВведите целые числа!", "Ошибка");                        
                        return;
                    }

                    textBox3.Text += Convert.ToString(a) + Environment.NewLine;

                }
            }
        }

       
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //Или так this.Close();
            //Или так Environment.Exit(0);
        }
    }
}

