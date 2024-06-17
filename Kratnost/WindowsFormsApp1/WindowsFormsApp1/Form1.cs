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
            int a;

            try
            { a = Convert.ToInt32(textBox1.Text); }
            catch
            {
                MessageBox.Show("Введите целое число","Ошибка");
                           
                return;
            }
            if(a==0)
                label1.Text = "Число не кратно 3 и 7";
            else if ((a % 3 == 0) && (a % 7 == 0))
                label1.Text="Число кратно 3 и 7";
            else
                label1.Text = "Число не кратно 3 и 7";
        }
    }
}
