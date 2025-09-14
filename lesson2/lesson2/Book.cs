using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Book:Item
    {
        public int id {  get; set; }
        public string title {  get; set; }
        public string author {  get; set; }
        public string description {  get; set; }

        public Book(int quantity, int price,int id, string title, string author,string description): base(quantity, price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.description = description;
        }

       public override string ToString()
        {
          return id+title+author+description;
        }
        
}
