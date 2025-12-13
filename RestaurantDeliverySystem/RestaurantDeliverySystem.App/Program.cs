using System;
using System.Globalization;
using RestaurantDeliverySystem.DTOs.DishDTOs;
using RestaurantDeliverySystem.DTOs.MenuDTOs;
using RestaurantDeliverySystem.App.Services;
using RestaurantDeliverySystem.App.Repositories;

class Program
{
    static void Main(string[] args)
    {
        // ----- SETUP -----
        var dishRepository = new DishRepository();
        var menuRepository = new MenuRepository();

        var dishService = new DishService(dishRepository, menuRepository);
        var menuService = new MenuService(menuRepository);

        Console.WriteLine("=== Tunisian Restaurant Demo ===\n");

        // ----- 1. CREATE MENU -----
        var createdMenu = menuService.Create(new PostMenuRequest
        {
            Title = "Restaurant Reychico"
        });

        Console.WriteLine($"Menu created: {createdMenu.Id} - {createdMenu.Title}");

        // ----- 2. CREATE DISHES -----
        var dishesToCreate = new PostDishRequest[]
        {
            new() { Name = "Lablabi", Price = 4.0M, MenuId = createdMenu.Id },
            new() { Name = "Mlawi", Price = 4.5M, MenuId = createdMenu.Id },
            new() { Name = "Makloub", Price = 12.0M, MenuId = createdMenu.Id },
            new() { Name = "Kefteji", Price = 7.0M, MenuId = createdMenu.Id },
            new() { Name = "Soufflé", Price = 1.7M, MenuId = createdMenu.Id },
            new() { Name = "Fricassé", Price = 2.0M, MenuId = createdMenu.Id }
        };

        Console.WriteLine("\nCreating dishes:");
        foreach (var request in dishesToCreate)
        {
            var dish = dishService.Create(request);
            Console.WriteLine($"Dish created: {dish.Name} ({dish.Price.ToString("0.00", CultureInfo.InvariantCulture)} TND)");
        }

        // ----- 3. READ ALL -----
        Console.WriteLine("\n=== All Dishes ===");
        var allDishes = dishService.GetAll();
        foreach (var dish in allDishes)
        {
            Console.WriteLine($"{dish.Id} | {dish.Name} - {dish.Price.ToString("0.00", CultureInfo.InvariantCulture)} TND");
        }

        // ----- 4. UPDATE FIRST DISH -----
        dishService.Update(allDishes[0].Id, new PutDishRequest
        {
            Name = "Lablabi Deluxe",
            Price = 9.5M,
            MenuId = createdMenu.Id
        });

        Console.WriteLine("\nUpdated first dish:");
        var updatedDish = dishService.GetById(allDishes[0].Id);
        Console.WriteLine($"{updatedDish.Id} | {updatedDish.Name} - {updatedDish.Price.ToString("0.00", CultureInfo.InvariantCulture)} TND");

        // ----- 5. DELETE LAST DISH -----
        var lastDish = allDishes[^1];
        dishService.Delete(lastDish.Id);
        Console.WriteLine($"\nDeleted last dish: {lastDish.Name}");

        // ----- 6. FINAL LIST -----
        Console.WriteLine("\n=== Final Dish List ===");
        var finalDishes = dishService.GetAll();
        foreach (var d in finalDishes)
        {
            Console.WriteLine($"{d.Id} | {d.Name} - {d.Price.ToString("0.00", CultureInfo.InvariantCulture)} TND");
        }

        Console.WriteLine("\n=== Demo Finished ===");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
