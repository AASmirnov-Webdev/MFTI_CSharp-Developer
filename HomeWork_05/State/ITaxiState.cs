using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05.Memento;

namespace HomeWork_05.State
{
    public interface ITaxiState
    {
        void Start(Taxi taxi);
        void Stop(Taxi taxi);
        void Accelerate(Taxi taxi);
        string GetStatus();
    }
}
