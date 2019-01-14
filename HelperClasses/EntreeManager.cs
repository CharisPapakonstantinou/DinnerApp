using DinnerApp.Models;
using System.Collections.Generic;

namespace DinnerApp.HelperClasses
{
    public static class EntreeManager
    {
        public static List<Entree> GetAll()
        {
            List<Entree> entrees = new List<Entree>();
            entrees.Add(new Entree()
            {
                ID = 1,
                Name = "Sopa",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Name = "Pasta", Amount = 3, Unit = "Cups"},
                    new Ingredient() { Name = "Tomato Sauce", Amount = 2, Unit = "Cups"},
                    new Ingredient() { Name = "Ground Beef", Amount = 1, Unit = "Pound"},
                    new Ingredient() { Name = "Cumin", Amount = 2, Unit = "Teaspoons"}
                }
            });
            entrees.Add(new Entree()
            {
                ID = 2,
                Name = "Lazy Enchiladas",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Name = "Corn Tortillas", Amount = 18, Unit = "Items"},
                    new Ingredient() { Name = "Enchilada Sauce", Amount = 2.5M, Unit = "Cups"},
                    new Ingredient() { Name = "Mexican Cheese", Amount = 0.75M, Unit = "Cups"},
                    new Ingredient() { Name = "Green Chilis", Amount = 1, Unit = "Can"}
                }
            });
            entrees.Add(new Entree()
            {
                ID = 3,
                Name = "Golden Chicken Bake",
                Ingredients = new List<Models.Ingredient>()
                {
                    new Ingredient() { Name = "Chicken Breast", Amount = 4, Unit = "Items"},
                    new Ingredient() { Name = "Cream of Chicken Soup", Amount = 10.5M, Unit = "Ounces"}
                }
            });

            return entrees;
        }
    }
}