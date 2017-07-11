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
            double a = 0, b = 0;
            string _format = "#0.00 USD";

            Console.Write("> а = "); a = Convert.ToDouble(Console.ReadLine());
            Console.Write("> b = "); b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("> a / b = " + (a/b).ToString(_format));
        }
    }
}
