using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.MenuDTOs
{
    public class GetAllMenuResponse
    {
        public GetAllMenuResponse(Menu menu)
        {
            Id = menu.Id;
            Title = menu.Title;
            RestaurantId = menu.RestaurantId;
        }

        public int Id { get; set; }
        public string Title { get; set; } = "";
        public int RestaurantId { get; set; }
    }
}
