namespace RestaurantDeliverySystem.Entities
{
    public enum OrderStatus { Pending, Cooking, Delivering, Done }

    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Dish> Dishes { get; set; } = new();
        public decimal TotalPrice { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }

        public Customer? Customer { get; set; }

        public int? DeliveryDriverId { get; set; }
        public DeliveryDriver? DeliveryDriver { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;
    }
}
