using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Item
    {
        public int price {  get; set; }
        public int quantity { get; set; }

        public Item(int price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
        }
    }
}
