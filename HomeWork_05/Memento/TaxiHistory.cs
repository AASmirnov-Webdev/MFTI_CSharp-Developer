using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_05.Memento
{
    public class TaxiHistory
    {
        private Stack<TaxiMemento> _history = new Stack<TaxiMemento>();

        public void Save(Taxi taxi) => _history.Push(taxi.SaveState());
        public TaxiMemento? Undo() => _history.Count > 0 ? _history.Pop() : null;
    }
}
