using System.Collections.Generic;
using RestaurantDeliverySystem.App.Entities;
using RestaurantDeliverySystem.App.Repositories;

namespace RestaurantDeliverySystem.App.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;

        public CustomerService(CustomerRepository repo)
        {
            _repo = repo;
        }

        public Customer Create(Customer c) => _repo.Create(c);
        public List<Customer> GetAll() => _repo.GetAll();
        public Customer GetById(int id) => _repo.GetById(id);
        public bool Update(Customer c) => _repo.Update(c);
        public bool Delete(int id) => _repo.Delete(id);
    }
}
