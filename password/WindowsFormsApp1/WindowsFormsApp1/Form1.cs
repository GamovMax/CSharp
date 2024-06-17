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
            if(textBox1.Text == "")
                label2.Text = "Вы не ввели пароль";
            else if (textBox1.Text == "root")
                label2.Text ="Пароль верный";
            else
                label2.Text = "Пароль неверный";
        }
    }
}
