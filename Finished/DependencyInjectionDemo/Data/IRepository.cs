using System.Collections.Generic;
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