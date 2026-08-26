using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Interfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        Customer? GetCustomerById(int customerId);
        Customer? GetCustomerByEmail(string email);
        List<Customer> GetAllCustomers();
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void SaveChanges();
    }
}
