namespace RestaurantDeliverySystem.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public List<Dish> Dishes { get; set; } = new();

        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
