
using SalePriceCalculator.Services.Entity;

namespace SalePriceCalculator.Services.Contract
{
    public interface IUnitDiscount
    {
        public int FreeItems(Item item);
    }
}
