using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.CustomerDeliveryDTOs
{
    public class GetCustomerDeliveryByIdResponse
    {
        public GetCustomerDeliveryByIdResponse(CustomerDelivery customerDelivery)
        {
            Id = customerDelivery.Id;
            FullName = customerDelivery.FullName;
            Address = customerDelivery.Address;
            Phone = customerDelivery.Phone;
        }

        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
