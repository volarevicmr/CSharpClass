using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {

        static void Main(string[] args)
        {
            List<BankAccount> bankAccountsList = new List<BankAccount>{
                new BankAccount(AccType.Stednja, "HR0294937497262863"),
                new BankAccount(AccType.Tekuci, "HR04937747938967"),
                new BankAccount(AccType.Ziro, "HR0846728962387"),
                new BankAccount(AccType.Tekuci, "HR08235482756945988"),
                new BankAccount(AccType.Stednja, "HR06784528687634")
            };

            void print(List<BankAccount> list)
            {
                foreach (BankAccount b in list)
                {
                    Console.WriteLine(b.AccNumber);
                    Console.WriteLine(b.balance.ToString("C0"));
                    Console.WriteLine(b.type.ToString());
                }
            }

            bool exit = true;

            do
            {
                Console.WriteLine("Unesite 1 za ispis svih racuna, 2 za upis novog i 0 za izlazak: ");
                string x = Console.ReadLine();
                if (x == "1")
                {
                    print(bankAccountsList);
                }
                else if (x == "2")
                {
                    Console.WriteLine("Unesite tip racuna: Ziro, Stednja, Tekuci");
                    string type = Console.ReadLine();
                    Console.WriteLine("Unesite broj racuna: ");
                    string number = Console.ReadLine();
                    if(Enum.TryParse(type, out AccType accountType))
                    {
                        bankAccountsList.Add(new BankAccount(accountType, number));
                    }
                }
                else if (x == "0")
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Neispravan unos!");
                }
            } while (exit);
        }
    }
}
