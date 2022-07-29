using SalePriceCalculator.Services.Contract;

namespace SalePriceCalculator.Services.Services
{
    public class FlatDiscount : IFlatDiscount
    {
        public double GetDiscount(double item,double discount)
        {
            return item - item * (discount/100);
        }
    }
}
