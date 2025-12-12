namespace RestaurantDeliverySystem.DTOs.CustomerDTOs
{
    public class PostCustomerDeliveryRequest
    {
        public string FullName { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
