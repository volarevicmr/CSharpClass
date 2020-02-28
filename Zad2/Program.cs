using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = Int64.MaxValue;
            long num2 = 3;

            try
            {
                num2 = checked(num1 + num2);
                //num2 = num1 + num2;
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            Console.ReadKey();
        }
    }
}
