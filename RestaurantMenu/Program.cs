using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Beans = new MenuItem(2.5, "Yummy black beans!", "Sides", true);
            MenuItem GreenChilli = new MenuItem(2.5, "Colorado Green Chilli!", "Sides", true);
            MenuItem BeefBurrito = new MenuItem(3.0, "Fried beef wrapped in a flower tortilla!", "Main Course", true);
            Menu mexicanMenu = new Menu(new System.Collections.Generic.List<MenuItem> { Beans, GreenChilli, BeefBurrito});

            foreach(var item in mexicanMenu.MenuItem)
            {
                Console.WriteLine(item.ToString());
            }
        }

        
    }
}
