using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дефиниции
            string usercommand = "";

            // Потребителски команди
            do
            {
                Console.Write("$ ");
                usercommand = Console.ReadLine();

                if (usercommand.Contains("cmd01")) cmd01(usercommand);
                if (usercommand.Contains("cmd02")) Console.WriteLine( cmd02(usercommand));

            } while (usercommand != "exit");
        }
        // Само да се изпълнят
        public static void cmd01(string _input)
        {
            try
            {
                double _temp = 0;
                if (double.TryParse(_input.Split(' ')[1], out _temp))
                {
                    Console.WriteLine("\n\nРезултата от " + _temp.ToString() + "^2: " + (_temp*_temp).ToString());
                }
            }catch
            {

            }
        }

        // Да върнат референции

        public static int cmd02(string _input)
        {
            int _temp = 0;
            if (int.TryParse(_input.Split(' ')[1], out _temp))
            {
                _temp = _temp * _temp * _temp;
               
            }
            return _temp;
        }



    }
}
