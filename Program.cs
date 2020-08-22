using System;
using OrderPromotion.Models;
using OrderPromotion.Enums;
using OrderPromotion.Promotions;
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
            var order = cart.GetOrderByOrderId(1);
            decimal finalOrderPrice = 0;
            foreach (var item in order)
            {
                if(item.Key == ProductType.A)
                {
                    var aPromotion = new FirstPromotion(item.Key);
                    finalOrderPrice = finalOrderPrice + aPromotion.GetPrice(50, 130, 3);
                }
                else if(item.Key == ProductType.B)
                {
                    var bPromotion = new FirstPromotion(item.Key);
                    finalOrderPrice = finalOrderPrice + bPromotion.GetPrice(50, 130, 3);
                }
                else if(item.Key == ProductType.C || item.Key == ProductType.D)
                {
                    var cdPromotion = new SecondPromotion(item.Key);
                    finalOrderPrice = finalOrderPrice + cdPromotion.GetPrice(50, 130, 3);
                }
            }

            IEnumerable<IPromotion> promotions = new [] { firstPromotion, secondPromotion };
            
        }
    }
}
