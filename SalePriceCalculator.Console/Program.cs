using SalePriceCalculator.Console;
using SalePriceCalculator.Services.Entity;
using SalePriceCalculator.Services.Services;
using SalePriceCalculator.Services.Constant;

try
{
    var items = CustomerPurchase();
    DisplayTotalBill(items);
}
catch(Exception ex)
{
    // log exception 
}



List<Item> CustomerPurchase()
{
    // Use DI > AddTransient  
    ClsSales sales = new(new UnitDiscount(), new FlatDiscount(), null);
    var items = ClsData.GetData();
    var cusPurchase = new List<Item>();

    Console.WriteLine("----------Customer Unit Purchased-----------");
    foreach (var item in items)
    {
        Console.WriteLine("item Name:" + item.Name);
        Console.WriteLine("item Quantity:" + item.Quantity);
        Console.WriteLine("item FlatDiscount:" + item.FlatDiscount);
        Console.WriteLine("item Price:" + item.Price);        
        Console.WriteLine("item Unit Discount:" + item.UnitLavelDiscount?.Min + "\n");

        if (item.FlatDiscount > 0)
        {
            item.Price = sales.GetFlatDiscount(item.Price, item.FlatDiscount);
            item.Total = item.Price * item.Quantity;
        }
        else if (item.UnitLavelDiscount?.Min == item.Quantity)
        {
            item.Total = item.Price * item.Quantity;
            item.Quantity = sales.GetUnitDiscount(item);
        }
        else
        {
            item.Total = item.Price * item.Quantity;
        }
        cusPurchase.Add(item);
    }
    return cusPurchase;
}

void DisplayTotalBill(List<Item> items)
{
    // Use DI > AddTransient  
    ClsSales sales = new(null, null, new FinalTotalDiscount());
    Console.WriteLine("----------Discount calculated on each item-----------");
    foreach (var item in items)
    {
        Console.WriteLine("item Name:" + item.Name);
        Console.WriteLine("item Quantity:" + item.Quantity);
        Console.WriteLine("item FlatDiscount:" + item.FlatDiscount);
        Console.WriteLine("item Price:" + item.Price);
        Console.WriteLine("item Total Price:" + item.Total);
        Console.WriteLine("item Unit Discount:" + item.UnitLavelDiscount?.Min + "\n");
    }
    var total = items.Sum(s => s.Total);
    Console.WriteLine("Enter 1 if purchased on Monday for extra 10% discount");
    int day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
        case 1:
            total = sales.GetFinalBillDiscount(total, Constant.WeekDayDiscount);
                Console.WriteLine("Total:" + total);
            break;
        default:
            Console.WriteLine("Total:" + total);
            break;
    }

}