using SalePriceCalculator.Services.Contract;
using SalePriceCalculator.Services.Entity;

namespace SalePriceCalculator.Services.Services
{
    public class UnitDiscount : IUnitDiscount
    {
        public int FreeItems(Item item)
        {          
            if (item?.UnitLavelDiscount?.Min > 0)
            {
                item.Quantity = item.UnitLavelDiscount.Min + item.UnitLavelDiscount.Free;
            }
            return item.Quantity;
        }      
    }
}
