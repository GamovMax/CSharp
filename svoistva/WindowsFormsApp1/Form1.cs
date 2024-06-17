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
            label1.Visible = false;

            Tv st1 = new Tv();

            try
            {
                st1.grom = Convert.ToInt32(textBox1.Text);// записываем в поле, используя аксессор set 
            }
            catch
            {
               
                MessageBox.Show("Значение громкости должно быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();                
                return;
            }


            if (st1.grom != 0)
            {
                label1.Text = Convert.ToString(st1.grom); // читаем поле, используя аксессор get
                label1.Visible = true;
            }
         

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создаётся класс Телевизор, объявляется в нем поле громкость звука," + Environment.NewLine + "для доступа к этому полю реализуется свойство. Громкость может быть в диапазоне от 0 до 100." + Environment.NewLine + "Записывает в поле значение из TextBox. Выводит значение поля в Label", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class Tv
    {
        private int gr; //объявление закрытого поля

        public int grom //объявление свойства
        {
            get // аксессор чтения поля
            {                
                return gr;                             
                
            }
            set // аксессор записи в поле
            {
                if ((value < 1)||(value > 100))
                {                    
                    MessageBox.Show("Громкость должна быть от 1 до 100!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    return;
                }
                else
                gr = value;

            }
        }
    }
}
