namespace RestaurantDeliverySystem.DTOs.CustomerLocalDTOs
{
    public class PostCustomerLocalRequest
    {
        public string FullName { get; set; } = "";
        public int TableNumber { get; set; }
        public string Phone { get; set; }
    }
}
