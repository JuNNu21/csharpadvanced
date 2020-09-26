using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp1
{
    interface ICustomerManager
    {
        void AddNewCustomer(int id, string name);
        void UpdateCustomer(int id, string name);
        void DeleteCustomer(int id);
        Array GetAllCustomers(string name);

        }

    class SuperMarket : ICustomerManager
    {
        public void AddNewCustomer(int id, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Array GetAllCustomers(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, string name)
        {
            throw new NotImplementedException();
        }
    }

    class InrerfaceDemo
    {
        
    }
}



/*Interfaces are similar to abstract classes, it allows abstract methods. However, u can't have implementation methods.
 * All interfaces are abstract claases, buut not vice versa.
 * A class can implement multiple interfaces at the same level. Methods of the interfaces are by default public and will remain public.
 * The classes that implement the interface must also implement them as public only Cannot change the access specifier.
 * Syntax for implementation is same as inheritance. However, a convention --> naming the interface prefixed with I */