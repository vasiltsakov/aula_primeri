using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] _table = {
                {"Иван",    "Георгиев", "25" },
                {"Васил",   "Василев",  "42" },
                {"Георги",  "Николов",  "54" },
                {"Валентин","Димов",    "58" },
                {"Димитър", "Недев",    "36" }

        };

            //Антетка на таблица
            Console.WriteLine("Име".PadRight(12) + "Фамилия".PadRight(12) + "Години".PadRight(12));
            Console.WriteLine("==============================");

            //Тяло на таблица
            //Пример с FOR
            //for (int i = 0; i < _table.Length/3; i++)
            //{
            //    for(int j = 0; j < 3;j++)
            //    {
            //        Console.Write(_table[i,j].PadRight(12));
            //    }
            //    Console.WriteLine();
            //}

            //Пример с While
            //Console.WriteLine("Дължина на масива: " + _table.Length);
            //int i = 0;
            //try
            //{
            //    while (i < 6)
            //    {
            //        Console.WriteLine(
            //            _table[i, 0].PadRight(12) +
            //            _table[i, 1].PadRight(12) +
            //            _table[i, 2].PadRight(12)
            //            );

            //        i++;
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("\n\nГрешчицааа!\n\n");
            //    Console.WriteLine(e.Message);
            //}

            //Пример с Do While
            int i = 0;
            do {

                Console.WriteLine(
                            _table[i, 0].PadRight(12) +
                            _table[i, 1].PadRight(12) +
                            _table[i, 2].PadRight(12)
                            );
                i++;
            } while (i < _table.Length/3);

        }
    }
}
