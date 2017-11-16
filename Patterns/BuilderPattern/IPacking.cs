
using System;
using System.Collections.Generic;

namespace VsCodeProOne.Patterns.BuilderPattern
{
    public interface IPacking
    {
        string Pack();
    }
    
    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }

    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }

    public class Bottle : IPacking
    {
        public string Pack()
        {
           return "Bottle";
        }
    }

    public abstract class Burger : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }

    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();

    }

    public class VegBurger : Burger
    {
        public override float Price()
        {
            return 25.0f;
        }

        public override string Name()
        {
            return "Veg Burger";
        }

    }

    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return nameof(ChickenBurger);
        }

        public override float Price()
        {
            return 50.5f;
        }
    }

    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return nameof(Coke);
        }

        public override float Price()
        {
            return 23.2f;
        }
    }

    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return nameof(Pepsi);
        }

        public override float Price()
        {
            return 35.0f;
        }
    }

    public class Meal
    {
        private List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public float Cost
        {
            get
            {
                var cost = 0.0f;
                foreach(var item in _items)
                {
                    cost += item.Price();
                }
                return cost;
            }
        }

        public void ShowItems()
        {
            foreach(var item in _items)
            {
                Console.Write("Item :" + item.Name());
                Console.Write(",Packing : " + item.Packing().Pack());
                Console.WriteLine(",Price : " + item.Price());
            }
        }

    }

    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }

    }

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
