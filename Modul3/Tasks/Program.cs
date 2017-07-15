using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int gladni_maimuni = 5;
            int banani = 3;
            int sandvichi = 10;

            if (gladni_maimuni <= (banani + sandvichi))
            {
                if (gladni_maimuni > banani)
                {
                    Console.WriteLine("Гладните маймуни са: " + gladni_maimuni);
                    Console.WriteLine("Бананите са: " + banani);
                    Console.WriteLine("Маймуни получаващи сандвич: " + (gladni_maimuni - banani));
                    Console.WriteLine("Оставащи сандвичи: " + (sandvichi - (gladni_maimuni - banani)));
                }
                else
                {
                    Console.WriteLine("Гладните маймуни са: " + gladni_maimuni);
                    Console.WriteLine("Бананите са: " + banani);
                    Console.WriteLine("Оставащи банани: " + (banani - gladni_maimuni));
                    Console.WriteLine("Сандвичи няма да се раздават");
                }
            }
            else
            {
                Console.WriteLine("Гладните маймуни са: " + gladni_maimuni);
                Console.WriteLine("Маймуни получаващи банан: " + banani);
                Console.WriteLine("Маймуни получаващи сандвич: " + sandvichi);
                Console.WriteLine("Оставащи гладни маймуни: " + (gladni_maimuni - (banani + sandvichi)));
            }
        }
    }
}
