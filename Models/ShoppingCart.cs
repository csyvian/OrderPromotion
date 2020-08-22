using OrderPromotion.Enums;
using System.Collections.Generic;

namespace OrderPromotion.Models
{
    public class ShoppingCart 
    { 
        private Dictionary<int, Dictionary<ProductType, int>> orders 
            = new Dictionary<int, Dictionary<ProductType, int>>() 
            {
                {
                    1, 
                    new Dictionary<ProductType, int>()
                    {
                        { ProductType.A, 1 },
                        { ProductType.B, 1 },
                        { ProductType.C, 1 }
                    }
                },
                {
                    2, 
                    new Dictionary<ProductType, int>()
                    {
                        { ProductType.A, 5 },
                        { ProductType.B, 5 },
                        { ProductType.C, 1 }
                    }
                },
                {
                    3, 
                    new Dictionary<ProductType, int>()
                    {
                        { ProductType.A, 3 },
                        { ProductType.B, 5 },
                        { ProductType.C, 1 },
                        { ProductType.D, 1 }
                    }
                }

            };

        public Dictionary<ProductType, int> GetOrderByOrderId(int orderId)
        {
            return orders[orderId];
        }
    }
}