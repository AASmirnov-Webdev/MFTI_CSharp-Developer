using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03
{
    public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public void FeedAnimal(object sender, EventArgs e)
        {
            if (sender is Animal animal)
            {
                Console.WriteLine($"{Name} кормит {animal.Name} #{animal.Number}");
                animal.IncreaseHealth(50);
            }
        }

        public void UnsubscribeFromAnimal(object sender, EventArgs e)
        {
            if (sender is Animal animal)
            {
                animal.NeedsFood -= FeedAnimal;
                Console.WriteLine($"{Name} отписался от {animal.Name} #{animal.Number}");
            }
        }
    }
}
