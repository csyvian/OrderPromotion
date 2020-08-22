namespace OrderPromotion.Promotions
{
    public class FirstPromotion : IPromotion
    {
        private int productCount;
        public FirstPromotion(ProductType productType)
        {
            if(productType == ProductType.A || productType == ProductType.B)
                productCount++;
        }

        // public decimal GetPrice(int productCount) 
        // {
        //     return 130 * (productCount / 3) + 50 * (productCount % 3);
        // }

        public decimal GetPrice(decimal itemPrice, decimal packPrice, int packSize) 
        {
            return packPrice * (productCount / packSize) + itemPrice * (productCount % packSize);
        }
    }
}