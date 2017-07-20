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
            int[] a = { 1, 2, 3 };
            int i = 0, j = 0;
            int r_op = 0; // Тук записваме произволната команда
            int r_num1 = 0; // Номер на първо произволно число от масива
            int r_num2 = 0; // Номер на второ произволно число от масива
            var r = new Random();

            string rs = ""; // Тук ще пазим текстовата формула до момента
            int res = 0; // Тук ще смятаме произволно
            int found = 0; // Тук пазим колко формули сме намерили до момента

            for (i = 0; i < 100; i++)
            {
                rs = ""; // Всяка нова итерация ще изтриваме rs и res 
                res = 0;
                for (j = 0; j < 20; j++)
                {
                    r_op = r.Next(0, 3); // Тук се решава дали ще събираме, изваждаме или делим
                    r_num1 = r.Next(0, 3);
                    r_num2 = r.Next(0, 3);

                    switch (r_op)
                    {
                        case 0:
                            {
                                res += a[r_num1] + a[r_num2];
                                rs += a[r_num1] + " + " + a[r_num2] + " + ";
                                break;
                            }
                        case 1:
                            {
                                res += a[r_num1] * a[r_num2];
                                rs += a[r_num1] + " * " + a[r_num2] + " + ";
                                break;
                            }
                        case 2:
                            {
                                res += a[r_num1] - a[r_num2];
                                rs += a[r_num1] + " - " + a[r_num2] + " + ";
                                break;
                            }
                    }

                    if (res == 15)
                    { // Воала. Намерихме правилна формула
                        Console.WriteLine(rs + " 0 = 15\n");
                        found++;
                        break;
                    }

                }
                if (found > 5) break; // Не искаме повече от 5 формули
            }
        }
    }
}
