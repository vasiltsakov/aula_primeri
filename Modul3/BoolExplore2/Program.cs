using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolExplore2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _i = { 4, 3, 2 };
            int _ui = 0;
            string _input = "0";

            Console.Write("Моля въведете индекс: ");
            _input = Console.ReadLine();

            bool _check_01 = int.TryParse(_input, out _ui);

            //_ui = (_ui <= _i.Length) ? _ui : _i.Length;
            //_ui = (_ui > 0) ? _ui : 1;

            try
            {
                Console.Write("Елемент " + _ui.ToString() + " от масива е: ");
                Console.WriteLine(_i[_ui-1]);
            }
            catch
            {
                Console.WriteLine("недифиниран!");
            }

            //switch(_ui)
            //{
            //    case 1:
            //        {
            //            Console.Write("Първият елемент на масива е: ");
            //            Console.WriteLine(_i[_ui-1]);
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.Write("Вторият елемент на масива е: ");
            //            Console.WriteLine(_i[_ui - 1]);
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.Write("Третият елемент на масива е: ");
            //            Console.WriteLine(_i[_ui - 1]);
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("В масива няма стойност за този индекс.\nОпитайте с число от 1 до 3.");
            //            break;
            //        }

            //}

            //if (_check_01 )
            //{
            //    Console.WriteLine(_i[_ui - 1]);
            //}
        }
    }
}
