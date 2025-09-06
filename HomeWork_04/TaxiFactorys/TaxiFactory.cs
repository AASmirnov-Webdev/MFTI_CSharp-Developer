using HomeWork_04.Drivers;
using HomeWork_04.Movements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04.TaxiFactorys
{
    public abstract class TaxiFactory
    {
        public abstract Driver CreateDriver();
        public abstract Movement CreateMovement();
    }
}
