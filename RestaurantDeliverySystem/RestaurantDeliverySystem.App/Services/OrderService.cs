using System.Collections.Generic;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.App.Repositories;

namespace RestaurantDeliverySystem.App.Services
{
    public class OrderService
    {
        private readonly OrderRepository _repo;

        public OrderService(OrderRepository repo)
        {
            _repo = repo;
        }

        public Order Create(Order o) => _repo.Create(o);
        public List<Order> GetAll() => _repo.GetAll();
        public Order GetById(int id) => _repo.GetById(id);
        public bool Update(Order o) => _repo.Update(o);
        public bool Delete(int id) => _repo.Delete(id);
    }
}
