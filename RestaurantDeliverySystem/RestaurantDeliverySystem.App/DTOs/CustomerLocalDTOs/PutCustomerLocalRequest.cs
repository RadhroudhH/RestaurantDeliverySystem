namespace RestaurantDeliverySystem.DTOs.CustomerDTOs
{
    public class PutCustomerLocalRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public int TableNumber { get; set; }
    }
}
