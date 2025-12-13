using RestaurantDeliverySystem.DTOs.CustomerDeliveryDTOs;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.App.Repositories;

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

        public GetCustomerDeliveryByIdResponse GetById(int id)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return null;
            return new GetCustomerDeliveryByIdResponse(entity);
        }

        public GetCustomerDeliveryByIdResponse Post(PostCustomerDeliveryRequest request)
        {
            var entity = new CustomerDelivery
            {
                FullName = request.FullName,
                Phone = request.Phone,
                Address = request.Address
            };

            var created = _repository.Create(entity);
            return new GetCustomerDeliveryByIdResponse(created);
        }

        public GetCustomerDeliveryByIdResponse Put(int id, PutCustomerDeliveryRequest request)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return null;

            entity.FullName = request.FullName;
            entity.Phone = request.Phone;
            entity.Address = request.Address;

            _repository.Update(entity); // Update returns bool, not entity
            return new GetCustomerDeliveryByIdResponse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
