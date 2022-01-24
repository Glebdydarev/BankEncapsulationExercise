using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(500000.00);
            Console.WriteLine("New bank account created");
            Console.WriteLine($"Your balance is: {myAccount.GetBalance()}");

            var secondAccount = new BankAccount();
            Console.WriteLine("2nd account created");
            Console.WriteLine($"Your 2nd account balance is: {secondAccount.GetBalance()}");

            secondAccount.Deposit(1000000.00);
            Console.WriteLine("Deposit accepted.");
            Console.Write($"New balance is: {secondAccount.GetBalance()}");


         }
    }
}
