using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6BankAccount
{
    class Checking : Client
    {
       //Constructors
       public Checking()
        {

        }
        public Checking(string clientName, int clientAccountNumber, double checkingBalance, double savingsBalance)
        {
            this.clientName = clientName;
            this.clientAccountNumber = clientAccountNumber;
            this.checkingBalance = checkingBalance;
            this.savingsBalance = savingsBalance;
        }

        //method
        public override void AccountInformation()
        {
            Console.WriteLine("Account Holder: " + clientName);
            Console.WriteLine("Account Number: " + clientAccountNumber);
            Console.WriteLine("Checkings Balance: " + checkingBalance);

            List<string> moneyOption = new List<string>();
            moneyOption.Add("\n Deposit Enter 1");
            moneyOption.Add("\n Withdraw Enter 2");
            moneyOption.Add("\n Exit Enter 3");

            foreach (string money in moneyOption)
            {
                Console.WriteLine(money);
            }
                int userOption = int.Parse(Console.ReadLine());

                switch(userOption)
                {
                    case 1:
                        Console.WriteLine("Enter Amount You would like to Deposite: " + "Current Balance: " + checkingBalance);
                        double userDeposit = double.Parse(Console.ReadLine());
                        double moneyOptionDeposit = checkingBalance + userDeposit;
                        Console.WriteLine("New Checking Account Balance: " + moneyOptionDeposit);
                        break;

                    case 2:
                        Console.WriteLine("Enter Amount You would like to Withdraw: " + "Current Balance: " + checkingBalance);
                        double userWithdrawal = double.Parse(Console.ReadLine());
                        double moneyOptionWithdrawal = checkingBalance - userWithdrawal;
                        Console.WriteLine("New Checking Account Balance: " + moneyOptionWithdrawal);
                        break;

                    case 3:
                        Console.WriteLine("Thank you for choosing Nation WCCI");
                        break;

                        
                }
            


        }

    }
}
