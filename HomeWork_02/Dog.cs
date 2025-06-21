namespace HomeWork_02
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        // Переопределение метода Say с дополнением "Гав" (требование 4)
        public override void Say()
        {
            Console.WriteLine($"Собака {Name}, возраст {Age} лет. Гав!");
        }
    }

}