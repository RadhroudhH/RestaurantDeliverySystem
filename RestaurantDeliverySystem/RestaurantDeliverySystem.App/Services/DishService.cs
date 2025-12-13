using System.Collections.Generic;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.App.Repositories;
using RestaurantDeliverySystem.DTOs.DishDTOs;

namespace RestaurantDeliverySystem.App.Services
{
    public class DishService
    {
        private readonly DishRepository _repo;
        private readonly MenuRepository _menuRepo;

        public DishService(DishRepository dishRepo, MenuRepository menuRepo)
        {
            _repo = dishRepo;
            _menuRepo = menuRepo;
        }

        // Create using DTO
        public Dish Create(PostDishRequest request)
        {
            // Optional: validate that menu exists
            var menu = _menuRepo.GetById(request.MenuId);
            if (menu == null) return null;

            var dish = new Dish
            {
                Name = request.Name,
                Price = request.Price,
                MenuId = request.MenuId
            };
            return _repo.Create(dish);
        }

        public List<Dish> GetAll() => _repo.GetAll();
        public Dish GetById(int id) => _repo.GetById(id);

        // Update using DTO
        public bool Update(int id, PutDishRequest request)
        {
            var dish = _repo.GetById(id);
            if (dish == null) return false;

            dish.Name = request.Name;
            dish.Price = request.Price;
            dish.MenuId = request.MenuId;

            return _repo.Update(dish);
        }

        public bool Delete(int id) => _repo.Delete(id);
    }
}
