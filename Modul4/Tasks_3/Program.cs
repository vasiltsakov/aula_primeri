using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> cw = Console.WriteLine;
            List<string> z = new List<string>();

            z.Add("ементал");
            z.Add("дръжка");
            z.Add("вафла");
            z.Add("грозде");
            z.Add("буркан");
            z.Add("амфибия");

            z.Sort();
            cw(string.Join(", ", z));

            z.Reverse();
            cw(string.Join(", ", z));
        }
    }
}
