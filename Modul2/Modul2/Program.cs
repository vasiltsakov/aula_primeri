using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниране на променливи
            int a = 0, b = 0, temp = 0;

            //Събиране на числа
            a = 55;
            b = 10;
            Console.WriteLine("Стойностите на a и b са:");
            Console.Write("a = ");
            Console.WriteLine(a);
            Console.Write("b = ");
            Console.WriteLine(b+"\n\n");


            temp = a;
            a = b;
            b = temp;

            //Писане в конзола
            Console.WriteLine("Новите стойности на a и b са:");
            Console.Write("a = ");
            Console.WriteLine(a);
            Console.Write("b = ");
            Console.WriteLine(b);
        }
    }
}
