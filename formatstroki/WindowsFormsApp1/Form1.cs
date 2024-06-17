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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:MMM dd (ddd) mm:ss}", DateTime.Now); ;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Вывести текущую дату и время в виде отфоматированной строки." + Environment.NewLine + "Пример отформатированной строки:" + Environment.NewLine + "июн 30 (Пн) 09:31", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
