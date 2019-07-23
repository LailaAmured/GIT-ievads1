using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM18._07
{
    public class Machine
    //Izveidot klasi Bankomāts, kurai ir viena metode, naudas izņemšana. 
    //Bankomātā ir informācija par pieejamo naudas apjomu un par klientiem un viņu pieejamajiem atlikumiem. 
    //Consoles aplikācijā ir jāvar norādīt klienata id un cik naudas viņš grib izņemt.  
    //Ja naudas nepietiek ir jāparāda atbilstošs kļūdas paziņojums.
    { 
        public int Balance { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();

        public string Withdraw(string accounId, int amountToWithdraw)
        {
            string message = string.Empty;

            var account = Accounts.FirstOrDefault(a=>a.Id.Equals(accounId, StringComparison.InvariantCultureIgnoreCase));
            if (account == null)
            {
                return "No such account";
            }

            if (account.AccountBalance < amountToWithdraw)
            {
                return "Not enough money";
            }

            if (Balance < amountToWithdraw)
            {
                return "Not enough money in ATM";
            }

            Balance -= amountToWithdraw;
            account.AccountBalance -= amountToWithdraw;

            return $"Take your money {amountToWithdraw}"; 
        }
    }
}
