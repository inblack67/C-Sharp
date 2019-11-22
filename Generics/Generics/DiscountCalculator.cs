using System;
namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public double CalculateDiscount(TProduct product)
        {
            var price = product.Price = 67;
            var discount = 0.1 * price;
            return discount;
        }
    }
}
