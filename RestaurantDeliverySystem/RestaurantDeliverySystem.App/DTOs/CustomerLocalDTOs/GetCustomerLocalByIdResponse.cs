using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.CustomerLocalDTOs
{
    public class GetCustomerLocalByIdResponse
    {
        public GetCustomerLocalByIdResponse(CustomerLocal customer)
        {
            Id = customer.Id;
            FullName = customer.FullName;
            TableNumber = customer.TableNumber;
        }

        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public int TableNumber { get; set; }
    }
}
