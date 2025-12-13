using System.Collections.Generic;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.App.Repositories;

namespace RestaurantDeliverySystem.App.Services
{
    public class DeliveryDriverService
    {
        private readonly DeliveryDriverRepository _repo;

        public DeliveryDriverService(DeliveryDriverRepository repo)
        {
            _repo = repo;
        }

        public DeliveryDriver Create(DeliveryDriver d) => _repo.Create(d);
        public List<DeliveryDriver> GetAll() => _repo.GetAll();
        public DeliveryDriver GetById(int id) => _repo.GetById(id);
        public bool Update(DeliveryDriver d) => _repo.Update(d);
        public bool Delete(int id) => _repo.Delete(id);
    }
}
