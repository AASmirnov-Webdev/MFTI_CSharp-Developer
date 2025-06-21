namespace HomeWork_02
{
    // Сделал класс абстрактным (требование 5), чтобы нельзя было создавать его экземпляры
    public abstract class Animal
    {
        // Поле health сделано приватным, изменять его можно только через методы Feed и Punish (требование 2)
        private int health;

        // Имя можно задать только в конструкторе (требование 6)
        public string Name { get; }

        // Возраст можно задать только в конструкторе (требование 7)
        public int Age { get; }

        // Свойство для отображения состояния здоровья (требование 8)
        // Выбрал свойство, а не метод, так как это характеристика объекта, а не действие
        public string HealthStatus
        {
            get
            {
                return health <= 50 ? "Белый" : "Зеленый";
            }
        }

        // Конструктор
        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
            health = 50; // Допустим начальное значение здоровья = 50
        }

        // Метод для кормления (если здоровье больше 100 ед. то приравниваем к 100)
        public void Feed(int foodCount)
        {
            health = Math.Min(100, health + foodCount);
        }

        // Метод для наказания (если здоровье меньше 0 ед. то приравниваем к 0)
        public void Punish(int punchCount)
        {
            health = Math.Max(0, health - punchCount);
        }

        // Абстрактный метод Say, который нужно будет переопределить в наследниках (требование 4)
        public abstract void Say();
    }
}