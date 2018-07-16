using System;
using System.Collections.Generic;
using GrowTestApi.Model;
using GrowTestApi.Repositories;


namespace GrowTestApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(long id)
        {
            return _customerRepository.GetById(id);
        }

        public bool Create(Customer customer)
        {
            return _customerRepository.Create(customer);
        }

        public bool Update(long id, Customer customer)
        {
            return _customerRepository.Update(id, customer);
        }

        public bool Delete(long id)
        {
            return _customerRepository.Delete(id);
        }
    }
}