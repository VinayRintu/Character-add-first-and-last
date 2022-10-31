using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_add_first_and_last_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter any string ");
            string str=Console.ReadLine();

            var s = str.Substring(0,1);
            Console.WriteLine(s + str + s);
            Console.ReadLine();
        }
    }
}
