
using System;
using System.Collections.Generic;

namespace VsCodeProOne.Patterns.BuilderPattern
{
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


}
