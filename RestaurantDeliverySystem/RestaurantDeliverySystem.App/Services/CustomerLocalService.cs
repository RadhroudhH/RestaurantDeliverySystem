using RestaurantDeliverySystem.DTOs.CustomerLocalDTOs;
using RestaurantDeliverySystem.Entities;
using RestaurantDeliverySystem.App.Repositories;

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

        public GetCustomerLocalByIdResponse Post(PostCustomerLocalRequest request)
        {
            var entity = new CustomerLocal
            {
                FullName = request.FullName,
                Phone = request.Phone
            };

            var created = _repository.Create(entity); // not Post
            return new GetCustomerLocalByIdResponse(created);
        }

        public GetCustomerLocalByIdResponse Put(int id, PutCustomerLocalRequest request)
        {
            var entity = _repository.GetById(id); // now matches int
            if (entity == null) return null;

            entity.FullName = request.FullName;
            entity.Phone = request.Phone;

            _repository.Update(entity); // returns bool, ignore for response
            return new GetCustomerLocalByIdResponse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id); // matches repository
        }
    }
}
