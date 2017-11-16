
using System;

namespace VsCodeProOne.Patterns.BuilderPattern
{
    public static class FoodPattern
    {
        public static void Test()
        {
            var mealBuilder = new MealBuilder();
            PrintMealInfo(mealBuilder.PrepareVegMeal());
            PrintMealInfo(mealBuilder.PrepareNonVegMeal());

        }

        private static void PrintMealInfo(Meal meal)
        {
            meal.ShowItems();
            Console.WriteLine($"Total Cost : {meal.Cost}");
        }

    }


}
