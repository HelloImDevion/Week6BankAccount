using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client accountHolder = new Client("Mark Kingston", 8881293, 2525.20, 10000.64);
            
            Console.WriteLine("Welcome to National WCCI");
            accountHolder.AccountInformation();
            List<string> accountHolderOption = new List<string>();
            accountHolderOption.Add("\n Access Checkings account enter 1");
            accountHolderOption.Add("\n Access Savings account enter 2");
            accountHolderOption.Add("\n Exit enter 3");

            foreach (string holderOption in accountHolderOption)
            {
                Console.WriteLine(holderOption);
            }
                int userViewOption = int.Parse(Console.ReadLine());
            
                if (userViewOption == 3 )
                {
                    Console.WriteLine("Thank you for choosing Nation WCCI");
                    
                }

                else if (userViewOption > 3 || userViewOption < 1 )
                {
                    Console.WriteLine("Thank you for choosing Nation WCCI");
                    
                }
               
                else if (userViewOption == 1)
                {
                    Checking holderChecking = new Checking("Mark Kingston", 8881293, 2525.20, 10000.64);
                    holderChecking.AccountInformation();
                }
                else if (userViewOption == 2)
                {
                    Savings holderSaving = new Savings("Mark Kingston", 8881293, 2525.20, 10000.64, 5.00d);
                    holderSaving.AccountInformation();
                }

            
        }
    }
}
