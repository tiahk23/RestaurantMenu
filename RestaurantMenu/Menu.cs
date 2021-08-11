using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {
        

        public List<MenuItem>Items { get; set; }

        public DateTime LastUpdated { get; set; }
        public IEnumerable<object> MenuItem { get; internal set; }

        public Menu(List<MenuItem> menuItem)
        {
            this.MenuItem = menuItem;
            LastUpdated = DateTime.Now;

        }

    }
}
