## Домашнее задание №1

1. Рассчитать и вывести на экран площадь и периметр
прямоугольника стороны которого запросить у пользователя
(ввод с клавиатуры).
Задача на ввод/вывод информации, арифметические операции.

2. Найдите сумму `«1+2+3+…+n»`, где - `n` вводится пользователем с
клавиатуры.
Задача на цикл `«For…»`

3. Даны числа от **35** до **87**. Вывести на консоль те из них, которые
при делении на **7** дают остаток **1**, **2** или **5**.
Задача на цикл `«for (int 1 = начальное значение; i<конечное значение; i++)»`, а также на
условный оператор, так как нам нужно выводить не все числа из указанного диапазона, а
только те, которые отвечают определенному условию `(if (a … || …) {Console.WriteLine(i);}`,
а именно делятся на **7** и в остатке дают определенной число. Проверить остаток числа
от деления можно командой `«%»` (*пример: int a = 50 % 7; // a = 1*).

4. Представьте, что на складе имеется определённое количество
ящиков с яблоками. Когда подъезжает машина для погрузки,
попросить пользователя ввести с клавиатуры число –
количество ящиков, которые готова забрать машина. Цикл
должен работать до тех пор, пока все ящики не отгрузят со
склада. Предусмотреть тот случай, когда пользователь введёт
количество ящиков больше, чем есть на складе (сообщить о
том, что столько нет и отгрузить сколько есть).
Задача на цикл `«while…»`. Организовать цикл пока ящики есть (пока переменная
отвечающая за ящики больше **0**), в цикле вычитать из этой переменной то количество,
которое запросил пользователь с клавиатуры.
