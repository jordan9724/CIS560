using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560
{
    /// <summary>
    /// An object to represent a menu itme
    /// </summary>
    public class MenuItem
    {
        public int menuItemId { get; }
        public int restaurantId { get; }
        public string name { get; }
        public decimal price { get; }

        public MenuItem(int menuItemId, int restaurantId, string name, decimal price)
        {
            this.menuItemId = menuItemId;
            this.restaurantId = restaurantId;
            this.name = name;
            this.price = price;
        }
    }
}
