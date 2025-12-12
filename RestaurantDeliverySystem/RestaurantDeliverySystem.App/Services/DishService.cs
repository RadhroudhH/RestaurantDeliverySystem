using System.Collections.Generic;
using RestaurantDeliverySystem.App.Entities;
using RestaurantDeliverySystem.App.Repositories;

namespace RestaurantDeliverySystem.App.Services
{
    public class DishService
    {
        private readonly DishRepository _repo;

        public DishService(DishRepository repo)
        {
            _repo = repo;
        }

        public Dish Create(Dish dish) => _repo.Create(dish);
        public List<Dish> GetAll() => _repo.GetAll();
        public Dish GetById(int id) => _repo.GetById(id);
        public bool Update(Dish d) => _repo.Update(d);
        public bool Delete(int id) => _repo.Delete(id);
    }
}
