using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }
        public Menu(DateTime lastUpdated, List<MenuItem> item)
        {
            LastUpdated = lastUpdated;
            Items = item;
        }

        public void PrintMenuItem(MenuItem item)
        {
            Console.WriteLine($"\n{item.Name}, ${item.Price}\n{item.Description}");
             if (item.IsNew)
            {
                Console.WriteLine("New Item");
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Restaurant Menu \nLast Updated: ${LastUpdated}");
            Console.WriteLine("/nAppetizers:");
            foreach (MenuItem item in Items)
            {
                if (item.Category == "Appetizer")
                {
                    PrintMenuItem(item);
                }
            }
            Console.WriteLine("\nMain Courses:");
            foreach(MenuItem item in Items)
            {
                if (item.Category == "Main Course")
                {
                    PrintMenuItem(item);
                }
            }
            Console.WriteLine("\nDesserts:");
            foreach (MenuItem item in Items)
            {
                if (item.Category == "Dessert")
                {
                    PrintMenuItem(item);
                }
            }
        }

        public List<MenuItem> AddToMenu(MenuItem item)
        {
            Items.Add(item);
            return Items;
        }

        public void RemoveFromMenu(MenuItem item)
        {
            Items.Remove(item);
        }
    }
}
