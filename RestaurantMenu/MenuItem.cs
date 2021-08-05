using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string catagory, bool isNew)
        {
            Price = price;
            Description = description;
            Catagory = catagory;
            IsNew = isNew;
        }
    }
}
