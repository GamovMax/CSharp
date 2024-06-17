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
            int x1=0, x2=0;

            try
                {
                x1 = Convert.ToInt32(textBox1.Text);
                x2 = Convert.ToInt32(textBox2.Text);
                }
            catch
                {
                MessageBox.Show("Введите целое число");
            
                //ShowMessage("Введите целое число");
                return;
                }

            

            if (x1 > x2)
                label3.Text ="Выиграли гости";
            else if (x1 < x2)
                label3.Text = "Выиграли хозяева";
            else
                label3.Text = "Ничья";
        }

        private void MessageBoxButtons(string v1, string v2, object mB_OK)
        {
            throw new NotImplementedException();
        }
    }
}
