namespace HomeWork_02
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        // Переопределение метода Say с дополнением "Мяу" (требование 4)
        public override void Say()
        {
            Console.WriteLine($"Кот {Name}, возраст {Age} лет. Мяу!");
        }
    }
}