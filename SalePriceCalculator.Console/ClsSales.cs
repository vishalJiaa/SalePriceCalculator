using SalePriceCalculator.Services.Contract;
using SalePriceCalculator.Services.Entity;

namespace SalePriceCalculator.Console
{
    public class ClsSales
    {
       
        private readonly IUnitDiscount _unitDiscount;
        private readonly IFlatDiscount _flatDiscount;
        private readonly IFlatDiscount _finalTotalDiscount;
        public ClsSales(IUnitDiscount unitDiscount, IFlatDiscount flatDiscount, IFlatDiscount finalTotalDiscount)
        {
            _unitDiscount = unitDiscount;
            _flatDiscount = flatDiscount;
            _finalTotalDiscount= finalTotalDiscount;
    }

        public double GetFlatDiscount(double ammount,double discount)
        {
            return _flatDiscount.GetDiscount(ammount, discount);
        }

        public int GetUnitDiscount(Item item)
        {   
            return _unitDiscount.FreeItems(item);
        }

        public double GetFinalBillDiscount(double ammount, double discount)
        {
            return _finalTotalDiscount.GetDiscount(ammount, discount);
        }
    }
}
