using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class methoder
    {
        public methoder(int price1)
        {
            Price1 = price1;
        }

      

        public string Category1 { get; set; }
        public string ProductName1 { get; set; }
        public int Price1 { get; set; }

        // I have tried to put the method of the price sum in this class but i have got an error so there is no use of this class yet.

      /*  public static int summan(List<int>Price1)
        {
            var total1 = Price1.Sum(element => element.this.Price1.ToString());

           return total1();

        }
      */
    }
}
