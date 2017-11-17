
using System;

namespace VsCodeProOne.Patterns.BuilderPattern
{
    public static class FoodPattern
    {
        public static void Test()
        {
            Console.WriteLine("建造者模式测试...");
            var mealBuilder = new MealBuilder();
            PrintMealInfo(mealBuilder.PrepareVegMeal());
            PrintMealInfo(mealBuilder.PrepareNonVegMeal());
            Console.WriteLine("");
        }

        private static void PrintMealInfo(Meal meal)
        {
            meal.ShowItems();
            Console.WriteLine($"Total Cost : {meal.Cost}");
        }

    }


}
