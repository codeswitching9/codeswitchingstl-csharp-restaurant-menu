using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            IsNew = isNew;
        }

    }
}
