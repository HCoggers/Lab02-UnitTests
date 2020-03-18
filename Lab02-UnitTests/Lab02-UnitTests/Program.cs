using System;

namespace Lab02_UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                ATM();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong: " +
                    $"\n{e.Message}");
            }
            finally
            {
                Console.WriteLine("Have a nice day!");
            }
        }
        static void ATM(decimal balance = 5000)
        {
            try
            {
                bool reload = true;
                Console.Clear();
                Console.WriteLine("Welcome to my Magical ATM App" +
                    "\nPlease choose a transaction by selecting a number:" +
                    "\n" +
                    "\n1) View your current balance" +
                    "\n2) Make a Withdrawal" +
                    "\n3) Make a Deposit" +
                    "\n\t...or press \"X\" to exit");
                string transaction = Console.ReadLine();
                switch (transaction)
                {
                    case "1":
                        balance = GetBalance(balance);
                        Console.WriteLine($"Your balance is currently {balance}");
                        break;
                    case "2":
                        Console.WriteLine("How much cash would you like to Withdraw?");
                        string cashTaken = Console.ReadLine();
                        balance = Withdraw(cashTaken, balance);
                        Console.WriteLine($"You Successfully Withdrew {cashTaken}, your balance is now {balance}");
                        break;
                    case "3":
                        Console.WriteLine("How much cash would you like to Deposit?");
                        string cashGiven = Console.ReadLine();
                        balance = Deposit(cashGiven, balance);
                        Console.WriteLine($"You Successfully Deposited {cashGiven}, Your balance is currently {balance}");
                        break;
                    case "x":
                        reload = false;
                        break;
                    default:
                        throw (new Exception("That wasn't an option." +
                            "\nTransaction Cancelled."));
                }
                // Keep asking the user to pick a transaction until they choose to exit the application
                if (reload)
                {
                    string choice;
                    do
                    {
                        Console.WriteLine("Would you like to make another transaction? " +
                           "\n\t...enter \"Y\" or \"N\"");
                        choice = Console.ReadLine();
                        if (choice == "y")
                            ATM(balance);

                    } while (choice != "y" && choice != "n");

                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("Please enter a dollar amount." +
                    "\nTransaction Cancelled due to:" +
                    $"\n{e.Message}");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("I can't legally process that much." +
                    "\nTransaction Cancelled due to:" +
                    $"\n{e.Message}");
            }
        }
        static decimal GetBalance(decimal balance)
        {
            return balance;
        }
        static decimal Withdraw(string cashTaken, decimal balance)
        {
            decimal money = Convert.ToDecimal(cashTaken);
            decimal newBalance;
            if ((balance - money) >= 0)
                newBalance = balance - money;
            else
                throw (new Exception("You don't have that much money." +
                    "\nTransaction Cancelled."));
            return newBalance;
        }
        static decimal Deposit(string cashGiven, decimal balance)
        {
            decimal money = Convert.ToDecimal(cashGiven);
            decimal newBalance = balance + money;
            return newBalance;
        }
    }
}
