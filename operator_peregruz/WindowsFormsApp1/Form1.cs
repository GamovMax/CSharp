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

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Необходимо реализовать вариант сложения денег – чтобы можно было суммировать деньги в разных валютах. Для этого создайте отдельный класс, который будет предоставлять механизм конвертации денег по заданному курсу. Кроме этого, перегрузите для класса Money оператор сравнения «==» (при перегрузке данного оператора, обязательной является и перегрузка противоположного ему оператора «!=»).", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public class Money //объявление класса
        {
            public decimal Amount { get; set; } //объявление свойств
            public string Unit { get; set; }

            public Money(decimal amount, string unit) //объявление конструктора
            {
                Amount = amount;
                Unit = unit;
            }

            public static Money operator +(Money a, Money b) //перегрузка оператора «+»
            {                               
                return new Money(a.Amount + b.Amount, a.Unit);
            }

            public static bool operator ==(Money a, Money b) //перегрузка оператора «==»
            {
                if((a.Amount==b.Amount) && (a.Unit==b.Unit))
                return true;
                else
                return false;
            }

            public static bool operator !=(Money a, Money b) //перегрузка оператора «!=»
            {
                if ((a.Amount == b.Amount) && (a.Unit == b.Unit))
                return false;
                else
                return true;
            }
        }

        class ValHelper //объявление класса
        {
            public static Money CNV(Money a, decimal b) //объявление статического метода
            {
                a.Amount = a.Amount * b;
                a.Unit = "RUR";
                return a;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ch_1, ch_2; //объявление переменных

            try //обработка исключений
            {
                ch_1 = Convert.ToDecimal(textBox1.Text); //конвертирование из string в decimal и присваивание значения переменным
                ch_2 = Convert.ToDecimal(textBox4.Text);
                
            }
            catch
            {
                MessageBox.Show("Должны быть введены дробные или целые числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }


            Money myMoney1 = new Money(ch_1, comboBox1.Text); //создание объктов класса
            Money myMoney2 = new Money(ch_2, comboBox2.Text);


            if (myMoney1.Unit == "USD")
            {
                try
                {
                    myMoney1 = ValHelper.CNV(myMoney1, Convert.ToDecimal(textBox3.Text)); //вызов метода
                }
                catch
                {
                    MessageBox.Show("Должны быть введены дробные или целые числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }
            }
                

            if (myMoney2.Unit == "USD")
            {
                try
                {
                    myMoney2 = ValHelper.CNV(myMoney2, Convert.ToDecimal(textBox3.Text)); //вызов метода
                }
                catch
                {
                    MessageBox.Show("Должны быть введены дробные или целые числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }
            }
                

            label5.Text = Convert.ToString(myMoney1.Amount + myMoney2.Amount)+" RUR";


            if (myMoney1 == myMoney2)
                label7.Text = "Валюты равны";
            else
                label7.Text = "Валюты неравны";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;  //установление значения combobox'ов по умолчанию
            comboBox2.SelectedIndex = 0;
        }
    }
}
