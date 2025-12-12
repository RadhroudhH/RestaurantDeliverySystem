namespace RestaurantDeliverySystem.Entities
{
    public class DeliveryDriver
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Vehicle { get; set; } = "";
        public List<Order> AssignedOrders { get; set; } = new();
    }
}
