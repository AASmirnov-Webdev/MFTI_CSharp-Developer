using HomeWork_04.Drivers;
using HomeWork_04.Movements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04.TaxiFactorys
{
    public class CarriageTaxiFactory : TaxiFactory
    {
        public override Driver CreateDriver() => new Coachman();
        public override Movement CreateMovement() => new CarriageMovement();
    }
}
