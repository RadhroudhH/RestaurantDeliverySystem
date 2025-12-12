using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.MenuDTOs
{
    public class GetMenuByIdResponse
    {
        public GetMenuByIdResponse(Menu menu)
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
