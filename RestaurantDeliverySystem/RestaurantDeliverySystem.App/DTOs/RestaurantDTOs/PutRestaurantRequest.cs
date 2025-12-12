namespace RestaurantDeliverySystem.DTOs.RestaurantDTOs
{
    public class PutRestaurantRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
    }
}