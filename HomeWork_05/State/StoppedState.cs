using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05.Memento;

namespace HomeWork_05.State
{
    public class StoppedState : ITaxiState
    {
        public void Start(Taxi taxi) => taxi.SetState(new MovingState());
        public void Stop(Taxi taxi) => Console.WriteLine("Такси уже стоит");
        public void Accelerate(Taxi taxi) => taxi.SetState(new SpeedingState());
        public string GetStatus() => "Стоит";
    }
}
