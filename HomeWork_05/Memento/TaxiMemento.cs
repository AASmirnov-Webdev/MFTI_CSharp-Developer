using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_05.Memento
{
    public class TaxiMemento
    {
        public decimal Mileage { get; }
        public string Driver { get; }
        public string Status { get; }
        public DateTime Created { get; }

        public TaxiMemento(decimal mileage, string driver, string status)
        {
            Mileage = mileage;
            Driver = driver;
            Status = status;
            Created = DateTime.Now;
        }
    }
}
