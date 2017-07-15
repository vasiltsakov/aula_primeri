using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            string _format = "#0.00";

            Console.Write("> а = "); a = Convert.ToDouble(Console.ReadLine());
            Console.Write("> b = "); b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("> a / b = " + (a/b).ToString(_format));

            //Степенуване
            c = Math.Pow(a, b);
            Console.WriteLine("\n\nСтепенуване a на степен b = " + c.ToString());

            //Коренуване
            c = Math.Sqrt(b);
            Console.WriteLine("\n\nКорен квадратен на b = " + c.ToString());

            //Закръгление
            c = Math.Round(a, 2);
            Console.WriteLine("\n\nЗакръгление на а = " + c.ToString());
        }
    }
}
