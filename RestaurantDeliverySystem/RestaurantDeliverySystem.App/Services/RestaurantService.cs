using System.Collections.Generic;
using RestaurantDeliverySystem.App.Entities;
using RestaurantDeliverySystem.App.Repositories;

namespace RestaurantDeliverySystem.App.Services
{
    public class RestaurantService
    {
        private readonly RestaurantRepository _repo;

        public RestaurantService(RestaurantRepository repo)
        {
            _repo = repo;
        }

        public Restaurant Create(Restaurant restaurant)
        {
            return _repo.Create(restaurant);
        }

        public List<Restaurant> GetAll()
        {
            return _repo.GetAll();
        }

        public Restaurant GetById(int id)
        {
            return _repo.GetById(id);
        }

        public bool Update(Restaurant r)
        {
            return _repo.Update(r);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
