using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductApp.Model
{
    internal class Product
    {
        public int id;
        public string name;
        public int price;
        public int discount;

        public int DiscountedPrice()
        { return price-price*discount/100; }
    }
}
