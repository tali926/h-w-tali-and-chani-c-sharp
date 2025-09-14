using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Game:Item
    {
        public string name {  get; set; }
        public int id { get; set; }
        public string type {  get; set; }


        public Game(int quantity, int price, string name, int id, string type) : base(quantity, price)
        {
            this.name = name;
            this.id = id;
            this.type = type;

           

        }
    }
}
