using HomeWork_04;
using HomeWork_04.TaxiFactorys;
using HomeWork_04.TaxiOrders;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите тип такси:");
        Console.WriteLine("1 - Легковое");
        Console.WriteLine("2 - Мотоцикл");
        Console.WriteLine("3 - Грузовое");
        Console.WriteLine("4 - Гужевая повозка");

        var choice = Console.ReadLine();

        TaxiFactory factory;

        switch (choice)
        {
            case "1":
                factory = new CarTaxiFactory();
                break;
            case "2":
                factory = new MotoTaxiFactory();
                break;
            case "3":
                factory = new TruckTaxiFactory();
                break;
            case "4":
                factory = new CarriageTaxiFactory();
                break;
            default:
                Console.WriteLine("Неверный выбор");
                return;
        }

        var order = new TaxiOrder(factory);
        order.DisplayOrderInfo();

        Console.ReadKey();
    }
}