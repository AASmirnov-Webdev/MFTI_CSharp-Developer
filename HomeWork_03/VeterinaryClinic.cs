using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03
{
    public class VeterinaryClinic
    {
        public ObservableCollection<Animal> AnimalsInZoo { get; } = new ObservableCollection<Animal>();
        private Manager _manager;

        public VeterinaryClinic(Manager manager)
        {
            _manager = manager;
            AnimalsInZoo.CollectionChanged += AnimalsCollectionChanged;
        }

        private void AnimalsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (Animal animal in e.OldItems)
                {
                    animal.OnRemovedFromZoo();
                }
            }
        }

        public bool ExamineAnimal(Animal animal)
        {
            // Производим осмотр животного
            bool isHealthy = new Random().Next(0, 100) > 20; // 20% шанс, что животное нездорово

            if (isHealthy)
            {
                AnimalsInZoo.Add(animal);
                animal.Number = AnimalsInZoo.Count;
                animal.NeedsFood += _manager.FeedAnimal;
                animal.RemovedFromZoo += _manager.UnsubscribeFromAnimal;
                Console.WriteLine($"{animal.Name} #{animal.Number} принят в зоопарк!");
                return true;
            }
            else
            {
                Console.WriteLine($"{animal.Name} - данному животному отказано!");
                return false;
            }
        }
    }
}
