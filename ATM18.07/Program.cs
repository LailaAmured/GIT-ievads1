using System;
using System.Collections.Generic;

namespace ATM18._07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot klasi Bankomāts, kurai ir viena metode, naudas izņemšana. 
            //Bankomātā ir informācija par pieejamo naudas apjomu un par klientiem un viņu pieejamajiem atlikumiem. 
            //Consoles aplikācijā ir jāvar norādīt klienata id un cik naudas viņš grib izņemt.  
            //Ja naudas nepietiek ir jāparāda atbilstošs kļūdas paziņojums. 

            Machine atm1 = new Machine();
            {
                atm1.Balance = 1000;
            }

            Account account1 = new Account()
            {
                Id = "123",
                AccountBalance = 100
            };

            Account account2 = new Account()
            {
                Id = "234",
                AccountBalance = 50
            };

            atm1.Accounts.Add(account1); 
            atm1.Accounts.Add(account2);

            do
            {
                Console.Write("Enter account Id:");
                var userAccountId = Console.ReadLine();

                Console.Write("Enter amount:");
                var amount = int.Parse(Console.ReadLine());
                var result = atm1.Withdraw(userAccountId, amount); 
                Console.WriteLine(result);

                Console.Write("Want to continue (Y/N):");
                var contin = Console.ReadLine();

                if (contin == "Y")
                {
                    continue;
                }

                else
                {
                    break;
                }
            } while (true);
                      
                

        }
    }
}
