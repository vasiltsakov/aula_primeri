using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool _b = true;
            //bool _test = 5 > 10;

            //Console.WriteLine(_test);

            int[] _i = { 4, 3, 2 };
            int _ui = 0;
            string _input = "0";

            Console.Write("Моля въведете индекс: ");
            _input = Console.ReadLine();

            bool _check_01 = int.TryParse(_input, out _ui);
            bool _check_02 = _ui <= _i.Length;
            bool _check_03 = _ui > 0;

            if (_check_01 && _check_02 && _check_03)
            {
                Console.WriteLine(_i[_ui - 1]);
            }

            if(!_check_01)
            {
                Console.WriteLine("Индекса трябва да бъде цяло число\n\n\n");
            }

            if (!_check_02)
            {
                Console.WriteLine("Индекса е прекалено голям\n\n\n");
            }

            if (!_check_03 && _check_01)
            {
                Console.WriteLine("Индекса е прекалено малък\n\n\n");
            }
        }
    }
}
