using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using Cinema.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDBContext context;

        public CustomerRepository(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
        }

        public Customer? GetCustomerById(int customerId)
        {
            return context.Customers.FirstOrDefault(customer => customer.customerID == customerId);
        }

        public Customer? GetCustomerByEmail(string email)
        {
            return context.Customers.FirstOrDefault(customer => customer.email == email);
        }

        public List<Customer> GetAllCustomers()
        {
            return context.Customers.ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            context.Customers.Remove(customer);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}
