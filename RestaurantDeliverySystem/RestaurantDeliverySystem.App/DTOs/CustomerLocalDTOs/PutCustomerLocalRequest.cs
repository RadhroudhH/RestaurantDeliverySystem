namespace RestaurantDeliverySystem.DTOs.CustomerLocalDTOs
{
    public class PutCustomerLocalRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public int TableNumber { get; set; }
        public string Phone { get; set; } = "";
    }
}
