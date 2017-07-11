using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProject
{
    class Program
    {
        enum Npotr {ime, familia, godini};

        static void Main(string[] args)
        {
            string[,] table = new string[3, 3];
            table[0, (int)Npotr.ime] = "Васил";
            table[0, (int)Npotr.familia] = "Василев";
            table[0, (int)Npotr.godini] = "25";

            table[1, (int)Npotr.ime] = "Иван";
            table[1, (int)Npotr.familia] = "Иванов";
            table[1, (int)Npotr.godini] = "36";

            table[2, (int)Npotr.ime] = "Петър";
            table[2, (int)Npotr.familia] = "Петров";
            table[2, (int)Npotr.godini] = "38";

            Console.Write("Номер на потребителя: ");
            int nPotr = Convert.ToInt32( Console.ReadLine());
            if (nPotr >=1 & nPotr <= 3)
            {
                Console.WriteLine("Име: " + table[nPotr - 1, (int)Npotr.ime]);
                Console.WriteLine("Фамилия: " + table[nPotr - 1, (int)Npotr.familia]);
                Console.WriteLine("Години: " + table[nPotr - 1, (int)Npotr.godini]);
            }
            else
            {
                Console.WriteLine("Невалиден номер");
            }

            //string[] row = new string[3];
            //row[0] = "Ред 1";
            //row[1] = "Ред 2";
            //row[2] = "Ред 3";

            //Console.WriteLine("Масив row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");

            //string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
            //Console.WriteLine("Ред 3 от масива parse e: " + parse[2] + "\n");
            //Console.WriteLine("Броят клетки на масива: \n" + "1,2,3,4,5,6,7,8,9 e " + parse.Length);

            //string sList = string.Join(";", parse);
            //Console.WriteLine("\nНовият стринг е: " + sList + "\n");

        }
    }
}
