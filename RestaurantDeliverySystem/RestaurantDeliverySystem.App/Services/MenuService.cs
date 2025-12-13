using System.Collections.Generic;
using System.Linq;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.App.Repositories;
using RestaurantDeliverySystem.DTOs.MenuDTOs;

namespace RestaurantDeliverySystem.App.Services
{
    public class MenuService
    {
        private readonly MenuRepository _repo;

        public MenuService(MenuRepository repo)
        {
            _repo = repo;
        }

        // Create using DTO
        public Menu Create(PostMenuRequest request)
        {
            var menu = new Menu
            {
                Title = request.Title
            };
            return _repo.Create(menu);
        }

        public List<Menu> GetAll() => _repo.GetAll();
        public Menu GetById(int id) => _repo.GetById(id);

        // Update using DTO
        public bool Update(int id, PostMenuRequest request)
        {
            var menu = _repo.GetById(id);
            if (menu == null) return false;

            menu.Title = request.Title;
            return _repo.Update(menu);
        }

        public bool Delete(int id) => _repo.Delete(id);
    }
}
