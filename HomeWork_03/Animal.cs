using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03
{
    public abstract class Animal : IAlive, IInventory
    {
        public int Health { get; set; } = 100;
        public int Number { get; set; }
        public string Name { get; set; }

        public event EventHandler NeedsFood;
        public event EventHandler RemovedFromZoo;

        protected virtual void OnNeedsFood()
        {
            NeedsFood?.Invoke(this, EventArgs.Empty);
        }

        public void OnRemovedFromZoo()
        {
            RemovedFromZoo?.Invoke(this, EventArgs.Empty);
        }

        public void DecreaseHealth(int amount)
        {
            Health -= amount;
            if (Health <= 0)
            {
                OnNeedsFood();
            }
        }

        public void IncreaseHealth(int amount)
        {
            Health += amount;
            if (Health > 100) Health = 100;
        }
    }
}
