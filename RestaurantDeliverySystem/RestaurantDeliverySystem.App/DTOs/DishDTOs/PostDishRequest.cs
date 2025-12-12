namespace RestaurantDeliverySystem.DTOs.DishDTOs
{
    public class PostDishRequest
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int MenuId { get; set; }
    }
}
