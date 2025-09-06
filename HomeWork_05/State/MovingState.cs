using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05.Memento;

namespace HomeWork_05.State
{
    public class MovingState : ITaxiState
    {
        public void Start(Taxi taxi) => Console.WriteLine("Такси уже движется");
        public void Stop(Taxi taxi) => taxi.SetState(new StoppedState());
        public void Accelerate(Taxi taxi) => taxi.SetState(new SpeedingState());
        public string GetStatus() => "Движется";
    }
}
