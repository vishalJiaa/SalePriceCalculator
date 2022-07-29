
namespace SalePriceCalculator.Services.Contract
{
    public interface IFlatDiscount
    {    
           public double GetDiscount(double billAmt,double discount);        
    }
}
