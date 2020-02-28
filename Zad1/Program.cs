using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool x;
            do
            {
                Console.WriteLine("Insert first whole number:");
                x = Int32.TryParse(Console.ReadLine(), out a);
            } while (!x);
            do
            {
                Console.WriteLine("Insert second whole number:");
                x = Int32.TryParse(Console.ReadLine(), out b);
            } while (!x && b!=0);

            double result = Convert.ToDouble(a) / b;
            Console.WriteLine(result.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(Convert.ToInt32(result));
            Console.WriteLine(result.ToString("E"));
            Console.WriteLine(result.ToString("F"));
            var g17Specifier = result.ToString("G17");
            var g17Value = Double.Parse(g17Specifier);
            Console.WriteLine($"{result:G17} = {g17Specifier} (G17): {result.Equals(g17Value)}");
            Console.WriteLine(result.ToString("N"));
            //U heksadecimalno se može pretvoriti samo broj tipa int
            int r = Convert.ToInt32(result);
            Console.WriteLine(r.ToString("X"));

            Console.ReadKey();
        }
    }
}
