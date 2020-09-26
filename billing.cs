using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp1
{
    class Billing
    {
        int custID;
        string cstName, cstAddress;
        double billAmount;

        public void setDetails(int id, string name, string address)
        {
            custID = id;
            cstName = name;
            cstAddress = address;
        }
        public void addBillAmount(double amount)
        {
            billAmount += amount;
        }
        public double getBill()
        {
            return billAmount;
        }
        public void DisplayBill()
        {
            Console.WriteLine("The name:" + cstName);
            Console.WriteLine("The Address:" + cstAddress);
            Console.WriteLine("The Date:" + DateTime.Now);
            Console.WriteLine("The Total Bill: " + billAmount);
        }
        static void Main(string[] args)
        {
            // dateTimeExample();
            exampleOnCustomer();
            exampleOnCustomer();
            exampleOnCustomer();
        }

        private static void exampleOnCustomer()
        {
            Billing cst = new Billing();
            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            string city = Console.ReadLine();
            int b = int.Parse(Console.ReadLine()); 
            cst.setDetails(i, n, city);
            cst.addBillAmount(b);
            Console.WriteLine("\n");
        }

    }
}