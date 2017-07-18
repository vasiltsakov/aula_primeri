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
            string[] _table = {"Иван","Гошо","Гергана" };

            //Антетка на таблица
            Console.WriteLine("Име");
            Console.WriteLine("=============");

            //Тяло на таблица
            for (int i=0;i<_table.Length;i++)
            {
                Console.WriteLine(_table[i]);
            }

        }
    }
}
