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
        TVSet myTV = new TVSet();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTV.plus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myTV.minus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                MessageBox.Show("Номер канала должен быть целым числом от 1 до 255!", "Ошибка");
                return;
            }

            
            try
            { myTV.ed(Convert.ToByte(textBox1.Text)); }
            catch
            {
                MessageBox.Show("Номер канала должен быть целым числом от 1 до 255!", "Ошибка");
                return;
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text =Convert.ToString(myTV.canal);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа переключения каналов." + Environment.NewLine + "Всего 255 каналов", "О программе");
        }
    }


    class TVSet //без указания модификатор доступа, класс будет internal
    {
        public byte canal=1;

        public void plus()
        {            
            canal++;

            if (canal==0)
            canal++;
        }
        public void minus()
        {
            canal--;

            if (canal == 0)
            canal--;
        }
        public void ed(byte ch)
        {
            canal= ch;
            
        }
    }

}
