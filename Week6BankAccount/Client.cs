using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6BankAccount
{
    class Client
    {
        // shared fields
        protected string clientName;
        protected int clientAccountNumber;
        protected double checkingBalance;
        protected double savingsBalance;

        // properties 
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public int ClientAccountNumber
        {
            get { return this.clientAccountNumber; }
            set { this.clientAccountNumber = value; }
        }
        public double CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }
        public double SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }

        //Constructor
        public Client()
        {

        }
        public Client(string clientName, int clientAccountNumber, double checkingBalance, double savingsBalance)
        {
            this.clientName = clientName;
            this.clientAccountNumber = clientAccountNumber;
            this.checkingBalance = checkingBalance;
            this.savingsBalance = savingsBalance;
        }

        //method
        public virtual void AccountInformation()
        {
            Console.WriteLine("Account Holder: " + clientName);
            Console.WriteLine("Account Number: " + clientAccountNumber);
            Console.WriteLine("Checkings Balance: " + checkingBalance);
            Console.WriteLine("Savings Balance: " + savingsBalance);
        }
    }
}
