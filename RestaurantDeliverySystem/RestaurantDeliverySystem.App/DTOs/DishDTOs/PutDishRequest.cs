namespace RestaurantDeliverySystem.DTOs.DishDTOs
{
    public class PutDishRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}
