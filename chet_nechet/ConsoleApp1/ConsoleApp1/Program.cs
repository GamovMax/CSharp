using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int a;
            bool c;
            string b = "y";
            while ((b == "y") || (b == "Y"))
            {
                Console.WriteLine("Введите число");

                try
                { a = Convert.ToInt32(Console.ReadLine()); }
                catch
                    {
                    Console.WriteLine("Введите целое число");
                    Console.ReadKey();
                    return;
                }

                if (a % 2 == 0)
                { Console.WriteLine("Число четное"); }
                else
                { Console.WriteLine("Число нечетное"); }

                c = true;
                while (c == true)
                {

                    Console.WriteLine("Повторить? Y/N");
                    b = Convert.ToString(Console.ReadLine());

                    if ((b != "y") && (b != "n") && (b != "Y") && (b != "N"))
                    {
                        Console.WriteLine("Ошибка! Введите Y или N");
                        c = true;
                    }
                    else
                    { c = false; }
                }


                }

        }
    }
}
