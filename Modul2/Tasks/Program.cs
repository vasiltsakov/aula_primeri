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
            /* ЗАДАЧА 1 - Работа със стрингове
             Декларирайте две променливи от тип string и им 
             присвоете стойности "Hello" и "World".
             Декларирайте променлива от тип object и й 
             присвоете стойността на конкатенацията на двете 
             променливи от тип string (не изпускайте интервала по средата).
             Декларирайте трета променлива от тип string и я 
             инициализирайте със стойността на променливата от тип object. 
             (Hint: Трябва да използвате type casting.)*/

            string sA = "Hello";
            string sB = "World";
            object oText = sA + " " + sB;
            string sC = (string)oText;

            Console.WriteLine(sC);

            /* ЗАДАЧА 2 - Работа със стрингове
             Да се въведат от командния ред 1 число или цифра и 
             1 дума/стринг. След това да изведе дължината на получения стринг при 
             конкатенация, тоест броя на символите в новополучения стринг при конкатенация. 
             (Hint: Трябва да преобразувате int към String и след това да конкатениратe.)*/


            Console.Write("\n\nЗапишете едно число ");
            int iA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Запишете една дума ");
            string sD = Console.ReadLine();

            string sCon = iA.ToString() + " " + sD;
            Console.WriteLine("\nОбщият стринг е: " + sCon);
            Console.WriteLine("\nОбщият брой символи на стринга е: " + sCon.Length);

        }
    }
}
