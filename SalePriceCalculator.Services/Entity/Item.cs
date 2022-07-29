
namespace SalePriceCalculator.Services.Entity
{
    public class Item
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }

        public int Quantity { get; set; }

        public double FlatDiscount { get; set; }

        public UnitLavelDiscount? UnitLavelDiscount { get; set; }
    }

    public class UnitLavelDiscount
    {
        public int Min { get; set; }
        public int Free { get; set; }
    }
}
