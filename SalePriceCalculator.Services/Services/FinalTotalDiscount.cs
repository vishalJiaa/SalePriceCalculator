using SalePriceCalculator.Services.Contract;

namespace SalePriceCalculator.Services.Services
{
    public class FinalTotalDiscount : IFlatDiscount
    {
        public double GetDiscount(double item, double discount)
        {
            return item - item * (discount/100);
        }
    }
}
