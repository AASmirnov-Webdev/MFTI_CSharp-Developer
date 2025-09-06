using HomeWork_05.Memento;
using HomeWork_05.Strategy;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====== Агрегатор такси 'С ветерком' ======\n");

        // Создаем такси
        var taxi = new Taxi("В947РА", "Алексей Смирнов");
        var history = new TaxiHistory();

        Console.WriteLine($"Создано такси: {taxi.Number}, водитель: {taxi.Driver}");
        Console.WriteLine($"Начальный статус: {taxi.GetStatus()}");
        Console.WriteLine($"Пробег: {taxi.Mileage} км\n");

        // Демонстрация смены тарифов (Strategy)
        Console.WriteLine("====== Демонстрация паттерна Strategy ======");
        Console.WriteLine($"Стандартный тариф (10 км): {taxi.CalculateCost(10)} руб.");

        taxi.SetTariff(new EconomyTariff());
        Console.WriteLine($"Эконом тариф (10 км): {taxi.CalculateCost(10)} руб.");

        taxi.SetTariff(new PremiumTariff());
        Console.WriteLine($"Премиум тариф (10 км): {taxi.CalculateCost(10)} руб.\n");

        // Демонстрация смены состояний (State)
        Console.WriteLine("====== Демонстрация паттерна State ======");

        taxi.Start();
        Console.WriteLine($"Статус после Start(): {taxi.GetStatus()}");
        taxi.AddMileage(5);

        taxi.Accelerate();
        Console.WriteLine($"Статус после Accelerate(): {taxi.GetStatus()}");
        taxi.AddMileage(10);

        taxi.Stop();
        Console.WriteLine($"Статус после Stop(): {taxi.GetStatus()}");
        Console.WriteLine($"Пробег: {taxi.Mileage} км\n");

        // Сохраняем состояние (Memento)
        Console.WriteLine("====== Демонстрация паттерна Memento ======");
        history.Save(taxi);
        Console.WriteLine("Состояние сохранено");
        Console.WriteLine($"Текущий пробег: {taxi.Mileage} км, водитель: {taxi.Driver}, статус: {taxi.GetStatus()}\n");

        // Меняем состояние
        taxi.Driver = "Сергей Виденин";
        taxi.AddMileage(20);
        taxi.Start();
        Console.WriteLine("Изменяем состояние:");
        Console.WriteLine($"Пробег: {taxi.Mileage} км, водитель: {taxi.Driver}, статус: {taxi.GetStatus()}\n");

        // Восстанавливаем состояние
        var savedState = history.Undo();
        if (savedState != null)
        {
            taxi.RestoreState(savedState);
            Console.WriteLine("Восстанавливаем сохраненное состояние:");
            Console.WriteLine($"Пробег: {taxi.Mileage} км, водитель: {taxi.Driver}, статус: {taxi.GetStatus()}");
            Console.WriteLine($"Состояние сохранено: {savedState.Created}");
        }

        Console.ReadKey();
    }
}