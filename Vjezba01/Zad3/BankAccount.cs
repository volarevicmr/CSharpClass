using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    public enum AccType
    {
        Stednja,
        Tekuci,
        Ziro
    };
    class BankAccount
    {
        public string AccNumber { get; set; }
        public double balance { get; set; }
        public AccType type { get; set; }

        public BankAccount(AccType accType, string accNumber)
        {
            AccNumber = accNumber;
            balance = 0;
            type = accType;
        }
    }

}
