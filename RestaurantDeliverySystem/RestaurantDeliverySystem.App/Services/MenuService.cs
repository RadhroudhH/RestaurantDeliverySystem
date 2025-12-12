using System.Collections.Generic;
using RestaurantDeliverySystem.App.Entities;
using RestaurantDeliverySystem.App.Repositories;

namespace RestaurantDeliverySystem.App.Services
{
    public class MenuService
    {
        private readonly MenuRepository _repo;

        public MenuService(MenuRepository repo)
        {
            _repo = repo;
        }

        public Menu Create(Menu m) => _repo.Create(m);
        public List<Menu> GetAll() => _repo.GetAll();
        public Menu GetById(int id) => _repo.GetById(id);
        public bool Update(Menu m) => _repo.Update(m);
        public bool Delete(int id) => _repo.Delete(id);
    }
}
