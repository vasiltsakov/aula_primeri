using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши твоето съобщение тук:");
            string myMsg = Console.ReadLine();

            test(myMsg);
        }

        public static void test(string msg)
        {
            Console.WriteLine("\n\n\nТвоето съобщение е: \n" + msg + "\n\n");
        }
    }
}
