using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HomeWork_03
{    
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем менеджера
            var manager = new Manager("Алексей");

            // Создаем ветеринарную клинику
            var clinic = new VeterinaryClinic(manager);

            // Создаем животных для тестирования
            Animal[] animalsToAdmit = {
            new Monkey(),
            new Rabbit(),
            new Tiger(),
            new Wolf(),
            new Monkey(),
            new Rabbit()
            };

            // Пытаемся принять животных в зоопарк
            foreach (var animal in animalsToAdmit)
            {
                clinic.ExamineAnimal(animal);
            }

            // Симулируем ухудшение здоровья у животных
            Console.WriteLine("\nИмитация снижения здоровья:");
            foreach (var animal in clinic.AnimalsInZoo)
            {
                animal.DecreaseHealth(60); // Вызовет событие NeedsFood
            }

            // Симулируем удаление животного из зоопарка
            Console.WriteLine("\nУдаление животного из зоопарка:");
            if (clinic.AnimalsInZoo.Count > 0)
            {
                var animalToRemove = clinic.AnimalsInZoo[0];
                clinic.AnimalsInZoo.Remove(animalToRemove);

                // Проверяем, что менеджер отписался от событий
                animalToRemove.DecreaseHealth(60); // Не должно вызывать реакцию менеджера
            }

            // Создаем и регистрируем некоторые вещи
            Console.WriteLine("\nПредметы инвентаря:");
            var items = new IInventory[] { new Table(), new Computer() };
            foreach (var item in items)
            {
                item.Number = new Random().Next(1000, 9999);
                Console.WriteLine($"{item.GetType().Name} #{item.Number}");
            }

            // Задержка
            Console.ReadKey();
        }
    }
}