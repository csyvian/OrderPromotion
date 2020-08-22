namespace OrderPromotion.Promotions
{
    public interface IPromotion
    {
        decimal GetPrice(decimal itemPrice, decimal packPrice, int packSize);
    }
}