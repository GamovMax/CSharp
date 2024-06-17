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
        double a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           

            try
            { a = Convert.ToDouble(textBox1.Text); }
            catch
            {
                MessageBox.Show("Введите целое или дробное число" + Environment.NewLine + "Пример: 2,3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text =Convert.ToString(a);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа при нажатии 'Ввод' конвертирует 'string' в 'double'." + Environment.NewLine + "При нажатии 'Вывод' конвертирует 'double' в 'string'", "О программе");
        }
    }
}
