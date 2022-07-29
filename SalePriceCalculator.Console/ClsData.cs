using SalePriceCalculator.Services.Entity;

namespace SalePriceCalculator.Console
{
    public static class ClsData
    {
        public static List<Item> GetData()
        {
            var items = new List<Item>
            {
                new Item { Name = "Thumbs up", Id = Guid.NewGuid(), Price = 20,FlatDiscount=10,Quantity=1},
                new Item { Name = "Toilet Cleaner", Id = Guid.NewGuid(), Price = 30,FlatDiscount=10,Quantity=2,UnitLavelDiscount = new UnitLavelDiscount{ Min = 2,Free=1 }},
                new Item { Name = "Cooking Oil Bottle - 1 liter", Id = Guid.NewGuid(), Price = 50,FlatDiscount=0,Quantity=2,UnitLavelDiscount = new UnitLavelDiscount{ Min = 2,Free=1 } },
                new Item { Name = "Tea", Id = Guid.NewGuid(), Price = 50,FlatDiscount=0,Quantity=1,UnitLavelDiscount = new UnitLavelDiscount{ Min = 2,Free=1 } },
                new Item { Name = "Mango", Id = Guid.NewGuid(), Price = 60,FlatDiscount=0,Quantity=1 }
            };
            return items;
        }


    }
}
