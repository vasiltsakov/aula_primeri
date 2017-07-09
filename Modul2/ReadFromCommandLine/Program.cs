using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниране на променливи
            int a = 0, b = 0;

            //Въвеждане на входни параметри
            Console.Write("Моля въведете стойност за a: ");
            a = Convert.ToInt32( Console.ReadLine());
            Console.Write("Моля въведете стойност за b: ");
            b = Convert.ToInt32( Console.ReadLine());

            //Печат на резултата
            Console.WriteLine("Сбора от числата е: " + (a + b).ToString());

            string text = "1";
            text += ", 2";
            text += ", 100";
            text += ", 4";
            text += ", 5";
            text += ", 6";
            text += ", 7";

            Console.WriteLine("\nСъбиране с +=: " + text + "\n");
            text = text.Replace(", ", ";");
            Console.WriteLine("Работа с Replace: " + text + "\n");
            Console.WriteLine("3ти знак: " + text.Split(';')[2] + "\n");


            Console.ReadKey();
        }
    }
}
