using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10BankingSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount("Raj",10000);
            sa.Balance();
            sa.Withdraw(12000);
            sa.Balance();
            sa.Deposite(2000);
            sa.Balance();
            sa.CalculateRateOfInterest();
            sa.Balance();

            Console.WriteLine("Current Account");

            CurrentAccount ca = new CurrentAccount("Readymade", 20000);
            ca.Balance();
            ca.Withdraw(100000);
            ca.Balance();
            ca.Withdraw(10000);
            ca.Balance();
            ca.Deposite(10000);
            ca.Balance();

            Console.WriteLine("Fixed Deposite Account");

            FixedDeposite fd = new FixedDeposite("Basavaraj", 200000);
            fd.Balance();
            fd.Deposite(200000);
            fd.Balance();
            fd.CalculateRateOfInterest();
        }
    }

    class Accounts
    {
        protected string Name;
        //protected int Amount;
        protected int balance;
        public Accounts(string New_name, int New_amount)
        {
            Name = New_name;
            balance = New_amount;
        }

        public void Deposite(int Amount)
        {
            balance = balance + Amount;
        }

        public void Withdraw(int Amount)
        {
            
            if(Amount<balance)
            {
                balance = balance - Amount;
                Console.WriteLine("Withdraw Success");

            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }

        public void Balance()
        {
            
            Console.WriteLine($"Balance is : {balance}");
        }
    }

    class SavingAccount:Accounts
    {
        public SavingAccount(string New_name, int New_amount):base(New_name, New_amount)
        {
            
        }
        
        public void CalculateRateOfInterest()
        {

            balance += (balance * 4) / 100;
        }

    }

    class CurrentAccount:Accounts
    {
        public CurrentAccount(string New_name, int New_amount) : base(New_name, New_amount)
        {

        }
        
        public void CalculateRateOfInterest()
        {

            balance += (balance * 0) / 100;
        }


    }

    class FixedDeposite : Accounts
    {
        public FixedDeposite(string New_name, int New_amount) : base(New_name, New_amount)
        {

        }

        public void CalculateRateOfInterest()
        {

            balance += (balance * 7) / 100;
            Console.WriteLine($"{balance}");
        }


    }
}
