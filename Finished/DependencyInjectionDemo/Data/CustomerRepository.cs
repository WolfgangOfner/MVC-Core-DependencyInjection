using System;
using System.Collections.Generic;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Data
{
    public class CustomerRepository : IRepository
    {
        public IEnumerable<Customer> Customers { get; }

        public Customer this[string name] => throw new NotImplementedException();

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}