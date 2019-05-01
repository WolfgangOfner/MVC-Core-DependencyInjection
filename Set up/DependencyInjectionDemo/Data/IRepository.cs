using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Data
{
    public interface IRepository
    {
        IEnumerable<Customer> Customers { get; }

        Customer this[string name] { get; }

        void AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);
    }
}
