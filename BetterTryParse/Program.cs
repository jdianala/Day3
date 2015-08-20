using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {
        static int? TryParseAsInt(string something)
        {
            int? myInt = 0;
            int test = 0;

            bool success = int.TryParse(something, out test);

            if (!success)
            {
                myInt = null;
            }

            else
            {
                myInt = test;
            }     

            return myInt;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number string: ");
            string output = Console.ReadLine();
            output = TryParseAsInt(output).ToString();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
