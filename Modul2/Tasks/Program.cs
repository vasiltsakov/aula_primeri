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
            
            /* ЗАДАЧА 1 - Работа с масиви
             Да се напише програма, която създава масив с 20 елемента от 
             целочислен тип и инициализира всеки от елементите със стойност равна на 
             индекса на елемента, умножен по 5. 
             Елементите на масива да се изведат на конзолата. 
             (Hint: Използвайте масив int[] и for цикъл.)*/

            int[] imA = new int[20];

            Console.WriteLine("\n\n");

            for (int k=0;k<imA.Length;k++)
            {
                imA[k] = k * 5;
                Console.WriteLine(imA[k]);
            }

            /* ЗАДАЧА 2 - Работа с масиви
            Да се напише програма, която чете два масива от конзолата и 
            проверява дали са еднакви. 
            (Hint: Два масива са еднакви, когато имат еднаква дължина и стойностите на 
            елементите в тях съответно съвпадат.)*/

            int[] firstArray = new int[5];
            int[] secondArray = new int[5];

            for(int l=0;l<5;l++)
            {
                Console.Write("Задайте {0} число от първия масив: ", l+1);
                
                firstArray[l] = Convert.ToInt32(Console.ReadLine());
            }

            for (int l = 0; l < 5; l++)
            {
                Console.Write("Задайте {0} число от втория масив: ", l + 1);
                
                secondArray[l] = Convert.ToInt32(Console.ReadLine());
            }
            for (int l = 0; l < 5; l++)
            {
                if (firstArray[l] != secondArray[l])
                {
                    Console.WriteLine("Не са еднакви масивите");
                    return;
                }

            }
            Console.WriteLine("Масивите са еднакви");

            /* ЗАДАЧА 3 - Работа с масиви
            Да се провери дали един масив е симетричен. 
            (Hint: За да проверим дали масивът е симетричен, 
            трябва да го обходим само до средата. 
            Тя е елементът с индекс array.length / 2. 
            При нечетна дължина на масива този индекс е средният елемент, 
            а при четна – елементът вляво от средата, понеже средата е между два елемента.)*/

            Console.Write("Въведете целочислена цифра: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the values of the array: ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    symmetric = false;

                }
            }
            Console.WriteLine("Симетричен ли е масива? {0}", symmetric);
        }

    
    }
}
