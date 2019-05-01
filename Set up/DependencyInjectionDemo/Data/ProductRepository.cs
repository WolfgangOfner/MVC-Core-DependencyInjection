using System.Collections.Generic;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Data
{
    public class ProductRepository : IRepository
    {
        private readonly Dictionary<string, Customer> _customers;

        public ProductRepository()
        {
            _customers = new Dictionary<string, Customer>();
            new List<Customer>
            {
                new Customer {Name = "John", Age = 20},
                new Customer {Name = "Jane", Age = 30},
                new Customer {Name = "Tom", Age = 40}
            }.ForEach(AddCustomer);
        }

        public IEnumerable<Customer> Customers => _customers.Values;

        public Customer this[string name] => _customers[name];

        public void AddCustomer(Customer customer)
        {
            _customers[customer.Name] = customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            _customers.Remove(customer.Name);
        }
    }
}