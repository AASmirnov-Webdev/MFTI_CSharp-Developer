using HomeWork_04.Drivers;
using HomeWork_04.Movements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04.TaxiFactorys
{
    public class MotoTaxiFactory : TaxiFactory
    {
        public override Driver CreateDriver() => new Biker();
        public override Movement CreateMovement() => new BikeMovement();
    }
}
