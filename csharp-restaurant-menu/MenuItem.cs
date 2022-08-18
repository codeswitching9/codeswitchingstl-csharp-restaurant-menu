using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class MenuItem
    {
        public MenuItem(double price, string name, string description, string category, bool isNew, DateTime dateCreated)
        {
            Price = price;
            Name = name;
            Description = description;
            Category = category;
            IsNew = isNew;
            DateCreated = dateCreated;
        }

        public double Price {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
