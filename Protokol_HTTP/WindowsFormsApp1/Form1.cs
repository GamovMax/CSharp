using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net; //В платформе .Net для работы с сетью существует пространство имен System.Net;
using System.IO; //В Си-шарп есть пространство имен System.IO, в котором реализованы все необходимые нам классы для работы с файлами. Чтобы подключить это пространство имен, необходимо в самом начале программы добавить строку using System.IO.
using System.Text.RegularExpressions; //Для того, чтобы работать с регулярными выражениями необходимо подключить в начале программы пространство имен using System.Text.RegularExpressions;


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
            MessageBox.Show("Программа выполняет следующее задание:" + Environment.NewLine + Environment.NewLine + "Ваша программа должна выводить в консоль заголовки уроков с главной страницы сайта http://mycsharp.ru/ (те, что в центральной колонке, 8 последних).", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string vrem = "",uri = "http://mycsharp.ru";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            //textBox1.Text = reader.ReadToEnd();


            vrem = reader.ReadToEnd();

            reader.Close();

            /*Сначала создается объект запроса при помощи статического метода Create класса WebRequest,
            в который передается адрес запрашиваемого ресурса. При этом возвращаемый объект необходимо 
            привести к типу HttpWebRequest, потому как метод Create возвращает различный объект запроса,
            основываясь на том, какой URI ему передали, это может быть, как в нашем случае, HTTP запрос,
            так и запрос к файловой системе(при этом возвращается объект FileWebRequest).

            Дальше мы создаем объект ответа HttpWebResponse путем вызова метода GetResponse
            у объекта запроса(при этом приводим его к типу HttpWebResponse).При вызове этого
            метода, на сервер отправляется запрос, и в результате мы получаем объект HttpWebResponse
            который содержит HTTP - заголовки, а также поток, с которого мы можем считать тело ответа.

            Дальше создается объект чтения потока StreamReader, в его конструктор передается поток
            ответа, который возвращает метод GetResponseStream, указываем необходимую кодировку, и
            выводим данные на экран. В результате мы увидим HTML код запрашиваемой страницы.*/





            Regex re_1 = new Regex("<font color="+'"'+"#454545"+'"'+ " size="+'"'+"6"+'"'+ @">\D*</font", RegexOptions.IgnoreCase); //Создание регулярного выражения. В Си-шарп работу с регулярными выражениями предоставляет класс Regex. 

            MatchCollection matches = re_1.Matches(vrem); //Matches – возвращает все подстроки соответствующие шаблону в виде коллекции типа MatchCollection. Каждый элемент этой коллекции типа Match.

            vrem = "";

            foreach (Match m in matches) //Вывод всех подстрок соответствующих шаблону
                vrem += m.Value;


            Regex re_2 = new Regex("</font", RegexOptions.IgnoreCase); //IgnoreCase – игнорирование регистра при поиске. Находит соответствия независимо прописными или строчными буквами в строке написано слово;

            vrem = re_2.Replace(vrem, Environment.NewLine); //Replace – возвращает строку, в которой заменены все подстроки, соответствующие шаблону, новой строкой:


            Regex re_3 = new Regex("<font color=" + '"' + "#454545" + '"' + " size=" + '"' + "6" + '"' + @">", RegexOptions.IgnoreCase);
            textBox1.Text = re_3.Replace(vrem, "");
                                              

        }
    }
}
