using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class InsuffBal : Exception
    {

        public InsuffBal(string message) : base(message) { }
    }



    public class Account
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit must be greater than zero.");
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}. Current Balance: ${balance}");
        }



        public void Withdraw(double amount)
        {
           

            if (amount > balance) throw new InsuffBal("Insufficient balance for your withdrawal.");


            balance -= amount;

            Console.WriteLine($"Withdrawn: ${amount}. Current Balance: ${balance}");
        }

        public double CheckBalance() => balance;
    }


    class Bank_Account
    {
        static void Main()
        {
            Account acc = new Account();

            try
            {
                Console.WriteLine("enter the deposit amount : ");
                int DepositAmount = int.Parse(Console.ReadLine());
                acc.Deposit(DepositAmount);

                Console.WriteLine("enter the Withdraw that you want to withdrawl \n: ");
                int WithdrawlAmount = int.Parse(Console.ReadLine());
                acc.Withdraw(WithdrawlAmount);

                Console.WriteLine("\n");
                double balance = acc.CheckBalance();
                Console.WriteLine($"///Current Balance: ${balance}");
            }
            
            catch (InsuffBal ex) { Console.WriteLine($"This error is for that your account has insufficient Balance : {ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"Unexpected Error occured: {ex.Message}"); }
            Console.ReadLine();
        }

    }
}