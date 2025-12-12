using RestaurantDeliverySystem.DTOs.CustomerDeliveryDTOs;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.Repositories;

namespace RestaurantDeliverySystem.Services
{
    public class CustomerDeliveryService
    {
        private readonly CustomerDeliveryRepository _repository;

        public CustomerDeliveryService()
        {
            _repository = new CustomerDeliveryRepository();
        }

        public List<GetAllCustomerDeliveryResponse> GetAll()
        {
            return _repository
                .GetAll()
                .Select(entity => new GetAllCustomerDeliveryResponse(entity))
                .ToList();
        }

        public GetCustomerDeliveryByIdResponse GetById(Guid id)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return null;

            return new GetCustomerDeliveryByIdResponse(entity);
        }

        public GetCustomerDeliveryByIdResponse Post(PostCustomerDeliveryRequest request)
        {
            var entity = new CustomerDelivery
            {
                Name = request.Name,
                Phone = request.Phone,
                Address = request.Address
            };

            var created = _repository.Post(entity);
            return new GetCustomerDeliveryByIdResponse(created);
        }

        public GetCustomerDeliveryByIdResponse Put(Guid id, PutCustomerDeliveryRequest request)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return null;

            entity.Name = request.Name;
            entity.Phone = request.Phone;
            entity.Address = request.Address;

            var updated = _repository.Put(id, entity);
            return new GetCustomerDeliveryByIdResponse(updated);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
