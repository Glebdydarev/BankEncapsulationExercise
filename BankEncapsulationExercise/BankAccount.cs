using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
        
    {
       
        public BankAccount(double amount)
        
            {
            balance = amount;

            }

        public BankAccount()
        {
        }

        private double balance = 0;
        

        public void Deposit (double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
        

         
    }   
}
