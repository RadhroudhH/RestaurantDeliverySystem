using RestaurantDeliverySystem.Entities;

namespace RestaurantDeliverySystem.DTOs.DishDTOs
{
    public class GetDishByIdResponse
    {
        public GetDishByIdResponse(Dish dish)
        {
            Id = dish.Id;
            Name = dish.Name;
            Price = dish.Price;
            MenuId = dish.MenuId;
        }

        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int MenuId { get; set; }
    }
}
