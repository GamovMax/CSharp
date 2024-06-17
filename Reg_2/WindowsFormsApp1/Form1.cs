using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Для того, чтобы работать с регулярными выражениями необходимо подключить в начале программы пространство имен using System.Text.RegularExpressions;

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
            Regex re_1 = new Regex("(бля)[А-Яа-яё]*|(пизд)[А-Яа-яё]*|(хуй)[А-Яа-яё]*|(хуё)[А-Яа-яё]*|(хуе)[А-Яа-яё]*", RegexOptions.IgnoreCase);//IgnoreCase – игнорирование регистра при поиске. Находит соответствия независимо прописными или строчными буквами в строке написано слово;

            textBox1.Text = re_1.Replace(textBox1.Text, "Цензура"); //Replace – возвращает строку, в которой заменены все подстроки, соответствующие шаблону, новой строкой:
            
           
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Фильтр мата. Принимает исходную строку, и возвращает результат, где нехорошие слова заменены на «цензура». Предусмотрено множество форм таких слов.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
