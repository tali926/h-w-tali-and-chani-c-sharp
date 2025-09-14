using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Shelf<T>
    {
        public int shelfNumber {  get; set; }
        public string column {  get; set; }
        public int weight {  get; set; }
        public List <T> Items= new List<T>();

        public Shelf(int shelfNumber, int column, int weight)
        {
            this.shelfNumber = shelfNumber;
            this.colum = column;
            this.wihgt = weight;
        }
    }
}
