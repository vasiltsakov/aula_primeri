using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] row = new string[3];
            row[0] = "Ред 1";
            row[1] = "Ред 2";
            row[2] = "Ред 3";

            Console.WriteLine("Масив row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");

            string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
            Console.WriteLine("Ред 3 от масива parse e: " + parse[2] + "\n");
            Console.WriteLine("Броят клетки на масива: \n" + "1,2,3,4,5,6,7,8,9 e " + parse.Length);

            string sList = string.Join(";", parse);
            Console.WriteLine("\nНовият стринг е: " + sList + "\n");

        }
    }
}
