using OrderPromotion.Enums;

namespace OrderPromotion.Promotions
{
    public class SecondPromotion : IPromotion
    {
        private int productCCount;
        private int productDCCount;
        public SecondPromotion(ProductType productType)
        {
            if(productType == ProductType.C)
                productCCount++;
            else if(productType == ProductType.D)
                productDCount++;
        }

        public decimal GetPrice(decimal itemPrice, decimal packPrice, int packSize) 
        {
            var commonCount = Math.Min(productCCount, productDCount);
            return (packPrice * commonCount)  + (itemCPrice * (productCCount % commonCount)) + (itemDPrice * (productDCount % commonCount));
        }
    }
}