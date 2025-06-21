using System;

namespace HomeWorkOne
{
    internal class Program
    {
        /* +++++++++++++++++++++++++++++++++++++++++++ Домашняя работа №1 +++++++++++++++++++++++++++++++++++++++++++

        1.  Рассчитать и вывести на экран площадь и периметр прямоугольника стороны которого запросить
        	у пользователя (ввод с клавиатуры). Задача на ввод/вывод информации, арифметические операции.
            Задача на ввод/вывод информации, арифметические операции.

        2.  Найдите сумму «1+2+3+…+n», где n вводится пользователем с клавиатуры.
            Задача на цикл «For…».

        3.  Даны числа от 35 до 87. Вывести на консоль те из них, которые при делении на 7 дают остаток 1, 2 или 5.
            Задача на цикл «for (int 1 = начальное значение; i<конечное значение; i++)», а также на условный оператор,
            так как нам нужно выводить не все числа из указанного диапазона, а только те, которые отвечают
            определенному условию (if (a … || …) {Console.WriteLine(i);}, а именно делятся на 7 и в остатке дают
            определенной число. Проверить остаток числа от деления можно командой «%» 
            (пример: int a = 50 % 7; // a = 1).

        4.  Представьте, что на складе имеется определённое количество ящиков с яблоками. Когда подъезжает машина для
            погрузки, попросить пользователя ввести с клавиатуры число – количество ящиков, которые готова забрать 
            машина. Цикл должен работать до тех пор, пока все ящики не отгрузят со склада. Предусмотреть тот случай, 
            когда пользователь введёт количество ящиков больше, чем есть на складе (сообщить о том, что столько нет и
            отгрузить сколько есть). Задача на цикл «while…». Организовать цикл пока ящики есть (пока переменная 
            отвечающая за ящики больше 0), в цикле вычитать из этой переменной то количество, которое запросил 
            пользователь с клавиатуры.
        
        ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

        static void CalcAreaAndPerimeterRectangle() // Решение Задачи №1
        {
            // Ввод данных
            Console.Write("Введите длину прямоугольника: ");
            double rectangleLength = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            double rectangleWidth = double.Parse(Console.ReadLine());

            // Расчет параметров
            double rectangleArea = rectangleLength * rectangleWidth,
                   rectanglePerimeter = (rectangleLength + rectangleWidth) * 2;

            // Вывод результата
            Console.WriteLine($"\nПлощадь прямоугольника равна: {rectangleArea} кв.м.");
            Console.WriteLine($"Периметр прямоугольника равен: {rectanglePerimeter} м.");
        }

        static void CalcSummNumbers() // Решение задачи №2
        {
            // Ввод данных
            Console.Write("Введите число: ");
            double number = double.Parse(Console.ReadLine());

            // Вычисление значения
            double summNumbers = 0;
            for (int i = 1; i <= number; i++)
            {
                summNumbers += i;
            }

            // Вывод результата
            Console.WriteLine($"Сумма чисел равна = {summNumbers}");
        }

        static void CalcRemainderOfDivision(int minNumber, int maxNumber) // Решение задачи №3
        {
            for (int i = minNumber; i < maxNumber; i++)
            {
                int resultNumber = i % 7;

                if ((resultNumber == 1) || (resultNumber == 2) || (resultNumber == 5))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ShippingBoxesOfApples() // Решение задачи №4
        {
            // Ввод данных
            Console.Write("Введите общее кол-во ящиков на складе, шт.: ");
            int numberOfBoxesInStock = Int32.Parse(Console.ReadLine());

            Console.Write("Введите вместимость машины (кол-во ящиков, шт.): ");
            int numberOfBoxesInCar = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            // Остаток ящиков на складе
            int restOfTheBoxes = numberOfBoxesInStock;

            // Отгрузка ящиков
            while (restOfTheBoxes > 0)
            {
                if (numberOfBoxesInCar > restOfTheBoxes)
                {
                    Console.WriteLine($"\nВНИМАНИЕ!!! На складе нет {numberOfBoxesInCar} ящиков, будет отгружено {restOfTheBoxes} ящиков");
                    restOfTheBoxes = 0;
                }
                else
                {
                    Console.WriteLine($"Отгрузка ящиков в количестве {numberOfBoxesInCar} штук произведена!");
                    restOfTheBoxes -= numberOfBoxesInCar;
                }
            }

            // Завершение отгрузки
            Console.WriteLine("\nНа складе не осталось ящиков! Отгрузка завершена!");
        }


        // главный метод программы
        static void Main()
        {
            // ---------------------- Решение задачи №1 ----------------------------

            //CalcAreaAndPerimeterRectangle();

            // ---------------------- Решение задачи №2 ----------------------------

            //CalcSummNumbers();

            // ---------------------- Решение задачи №3 ----------------------------

            //CalcRemainderOfDivision(35, 87);

            // ---------------------- Решение задачи №4 ----------------------------

            //ShippingBoxesOfApples();

            // Задержка
            Console.ReadKey();
        }
    }
}