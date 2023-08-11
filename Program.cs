using SimpleProductApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            SetProductDetails(100, "shirt", 1200, 25,product1);
            PrintDetails(product1 );
            Product product2 = new Product();
            SetProductDetails(101, "T-shirt", 700, 18, product2);
            PrintDetails(product2);
        }

        static void PrintDetails(Product product)
        {
            Console.WriteLine("Id: " + product.id);
            Console.WriteLine("Name: " + product.name);
            Console.WriteLine("Price: " + product.price);
            Console.WriteLine("Discount: " + product.discount);
            Console.WriteLine("Discounted Price: " + product.DiscountedPrice());
            Console.WriteLine();
        }

        static void SetProductDetails(int v1, string v2, int v3, int v4,Product product)
        {
            product.id = v1;
            product.name = v2;
            product.price = v3;
            product.discount = v4;
        }

    }
}
