using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
   public class Produkten
   {
        

        public Produkten(string category, string productName, int price)
        {
            Category = category;
            ProductName = productName;
            Price = price;
        }

        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

      

        public string Print()
        {

          return this.Category.PadRight(10) + " " + this.ProductName.PadRight(15) + " " + this.Price.ToString().PadRight(10);

        }
       
   }
}
