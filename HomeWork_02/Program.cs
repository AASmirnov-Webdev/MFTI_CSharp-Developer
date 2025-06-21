namespace HomeWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2]
            {
                new Cat("Феникс", 5),
                new Dog("Джек", 15)
            };

            foreach (var animal in animals)
            {
                Test(animal);
            }
        }

        static void Test(Animal pet)
        {
            Console.WriteLine($"\nПроверка работоспособности программы {pet.GetType().Name} {pet.Name}...");
            pet.Say();

            // Тестируем различные сценарии
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)         // моделируем 5 случайных событий с питомцем
            {
                int action = rnd.Next(0, 2);    // выбор случайного действия Feed(0) или Punish(1)
                int amount = rnd.Next(5, 26);   // выбор случайного числа от 5 до 25 (ед. пищи или строгости наказания)

                if (action == 0)
                {
                    pet.Feed(amount);
                }
                else
                {
                    pet.Punish(amount);
                }
            }

            // Выводим результат тестирования с цветом
            Console.Write($"Состояние здоровья {pet.Name}: ");
            if (pet.HealthStatus == "Зеленый")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine(pet.HealthStatus);
            Console.ResetColor();

            // Задержка
            Console.ReadKey();
        }


    }
}