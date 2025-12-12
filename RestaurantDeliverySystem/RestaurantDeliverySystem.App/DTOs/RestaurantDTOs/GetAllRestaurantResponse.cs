using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.RestaurantDTOs
{
    public class GetAllRestaurantResponse
    {
        public GetAllRestaurantResponse(Restaurant restaurant)
        {
            Id = restaurant.Id;
            Name = restaurant.Name;
            Address = restaurant.Address;
        }

        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
