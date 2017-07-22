using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 8)
            {
                i += 2;
                Console.WriteLine(i.ToString());
                if (i != 10)
                {
                    i--;
                    Console.WriteLine(i.ToString());
                }
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
