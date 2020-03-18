using System;

namespace Lab02_UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void ATM()
        {
            decimal balance = 5000m;
            Console.WriteLine("Welcome to my Magical ATM App" +
                "\nPlease choose a transaction by selecting a number:");
            string transaction = Console.ReadLine();
            switch(transaction)
            {

            }
        }
        static decimal GetBalance(decimal balance)
        {
            return balance;
        }
        static decimal Withdraw(decimal moneyTaken, decimal balance)
        {
            decimal newBalance = balance - moneyTaken;
            return newBalance;
        }
        static decimal Deposit(decimal moneyGiven, decimal balance)
        {
            decimal newBalance = balance + moneyGiven;
            return newBalance;
        }
    }
}
