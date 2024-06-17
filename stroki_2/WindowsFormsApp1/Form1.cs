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
            string s = textBox1.Text;
            s = s.Remove(107);
            textBox1.Text = s.Substring(67);

            button1.Visible =false;
            button1.Enabled = false;

            button2.Visible = true;
            button2.Enabled = true;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа обрезает этот текст так, чтобы осталась только" + Environment.NewLine + "часть «Были описаны основные операторы и методы»", "О программе");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
