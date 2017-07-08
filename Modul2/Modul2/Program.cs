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

            //Събиране на a и b
            a += b;
            Console.WriteLine("\nСъбиране на a и b с a += b: ");
            Console.WriteLine("a = " + a);

            //Изваждане на b от a
            a -= b;
            Console.WriteLine("\nИзваждане на b от a с a -= b: ");
            Console.WriteLine("a = " + a+"\n\n");

            //Делене
            int aDel = a;
            int bDel = b;

            Console.WriteLine("a = " + aDel);
            Console.WriteLine("b = " + bDel);
            Console.WriteLine("\nСтандартно делене: "+aDel/bDel);
            Console.WriteLine("Остатък: " + aDel % bDel);
        }
    }
}
