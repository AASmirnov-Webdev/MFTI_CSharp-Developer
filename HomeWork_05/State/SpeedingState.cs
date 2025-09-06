using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05.Memento;

namespace HomeWork_05.State
{
    public class SpeedingState : ITaxiState
    {
        public void Start(Taxi taxi) => Console.WriteLine("Такси уже мчится");
        public void Stop(Taxi taxi) => taxi.SetState(new StoppedState());
        public void Accelerate(Taxi taxi) => Console.WriteLine("Такси уже на максимальной скорости");
        public string GetStatus() => "Мчится";
    }
}
