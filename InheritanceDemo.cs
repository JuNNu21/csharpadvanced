using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp1
{
    class Account
    {
        static int no = 111;
        public Account()
        {
            AccountNo = no;
            no++;
            Balance = 5000;//min balance
        }

        public int AccountNo { get; private set; }

        public string AccountHolder { get; set; }
        
        public double Balance { get; private set; }    // frpm C# 6.0, only get can be used. set not compulsory

        //Lambda exp
        public void Credit(double amount) => Balance += amount;

        public void Debit(double amount)
        {
            if (amount > Balance)
                throw new Exception("Insuffecient Funds");
            else
                Balance -= amount;
        }
    }

    //Derived/sub/child class will modify or add new functions to the base class
    class SBAccount:Account
    {
        //Inherits all the public,internal and protected members in the current class
        public void CalcInterest()
        {
            double quarter = 0.25;
            double interestRate = 6.5 / 100;
            double interest = Balance * quarter * interestRate;
            Credit(interest);

        }
    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            SBAccount sb = new SBAccount();
            sb.AccountHolder = MyConsole.getString("Enter the name: ");
            sb.CalcInterest();
            Console.WriteLine("The current balance is: " + sb.Balance);
            //for (int i = 0; i < 10; i++)
            //{
            //    acc = new Account();
            //}
        }
    }
}

//C# only supports one base class at any level(Single Inheritance)
//The base class functions can be modified in the derived class only if the base class version has a modifier called virtual.