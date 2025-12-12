using RestaurantDeliverySystem.DTOs.CustomerLocalDTOs;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.Repositories;

namespace RestaurantDeliverySystem.Services
{
    public class CustomerLocalService
    {
        private readonly CustomerLocalRepository _repository;

        public CustomerLocalService()
        {
            _repository = new CustomerLocalRepository();
        }

        public List<GetAllCustomerLocalResponse> GetAll()
        {
            return _repository
                .GetAll()
                .Select(entity => new GetAllCustomerLocalResponse(entity))
                .ToList();
        }

        public GetCustomerLocalByIdResponse GetById(Guid id)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return null;

            return new GetCustomerLocalByIdResponse(entity);
        }

        public GetCustomerLocalByIdResponse Post(PostCustomerLocalRequest request)
        {
            var entity = new CustomerLocal
            {
                Name = request.Name,
                Phone = request.Phone
            };

            var created = _repository.Post(entity);
            return new GetCustomerLocalByIdResponse(created);
        }

        public GetCustomerLocalByIdResponse Put(Guid id, PutCustomerLocalRequest request)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return null;

            entity.Name = request.Name;
            entity.Phone = request.Phone;

            var updated = _repository.Put(id, entity);
            return new GetCustomerLocalByIdResponse(updated);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
