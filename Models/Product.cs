using System.Linq;
using System; 
using System.Collections.Generic;
using OrderPromotion.Enums;

namespace OrderPromotion.Models
{
    public class Product
    {    
        public ProductType Id { get; set; }    
        public decimal Price { get; set; }

        private Dictionary<ProductType, decimal> products = new Dictionary<ProductType, decimal>();

        public void AddOrUpdateProduct(Product product)
        {
            if(products.ContainsKey(product.Id))   
                products[product.Id]= product.Price;
            else   
                products.Add(product.Id, product.Price);
        }
    }
}