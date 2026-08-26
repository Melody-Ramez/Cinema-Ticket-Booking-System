using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            customerRepository.AddCustomer(customer);
            customerRepository.SaveChanges();
        }

        public Customer? GetCustomerById(int customerId)
        {
            return customerRepository.GetCustomerById(customerId);
        }

        public Customer? GetCustomerByEmail(string email)
        {
            return customerRepository.GetCustomerByEmail(email);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }

        public void UpdateCustomer(int customerId, Customer updatedCustomer)
        {
            Customer? customer = customerRepository.GetCustomerById(customerId);

            if (customer != null)
            {
                customerRepository.UpdateCustomer(updatedCustomer);
                customerRepository.SaveChanges();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            Customer? customer = customerRepository.GetCustomerById(customerId);

            if (customer != null)
            {
                customerRepository.DeleteCustomer(customer);
                customerRepository.SaveChanges();
            }
        }

    }
}

