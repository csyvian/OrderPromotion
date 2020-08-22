using OrderPromotion.Enums;

namespace OrderPromotion.Promotions
{
    public class SecondPromotion : IPromotion
    {
        private int productCount;
        public SecondPromotion(ProductType productType)
        {
            if(productType == ProductType.C || productType == ProductType.D)
                productCount++;
        }

        public decimal GetPrice(decimal itemPrice, decimal packPrice, int packSize) 
        {
            return packPrice * (productCount / packSize) + itemPrice * (productCount % packSize);
        }
    }
}