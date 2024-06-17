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
            int s = 1;
            string[] qwe = new string[20];
            for (int i = 0; i < 20; i++, s=s+3)
            {
                qwe[i] =Convert.ToString(s);
            }

            listBox1.Items.AddRange(qwe);
        }
    }
}
