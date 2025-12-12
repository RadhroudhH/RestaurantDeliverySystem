using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.CustomerDTOs
{
    public class GetAllCustomerDeliveryResponse
    {
        public GetAllCustomerDeliveryResponse(CustomerDelivery customer)
        {
            Id = customer.Id;
            FullName = customer.FullName;
            Address = customer.Address;
            Phone = customer.Phone;
        }

        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
