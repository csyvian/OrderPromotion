using System;
using OrderPromotion.Models;
using OrderPromotion.Enums;
using System.Collections.Generic;

namespace OrderPromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var products = new List<Product>() 
            {
                new Product() { Id = ProductType.A, Price = 50 },
                new Product() { Id = ProductType.B, Price = 30 },
                new Product() { Id = ProductType.C, Price = 20 },
                new Product() { Id = ProductType.D, Price = 15 }
            };
            
            var cart = new ShoppingCart();
        }
    }
}
