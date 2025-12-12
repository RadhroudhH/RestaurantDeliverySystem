namespace RestaurantDeliverySystem.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }

        public int MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
