using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_05.Strategy
{
    public class EconomyTariff : ITariffStrategy
    {
        public decimal CalculateCost(decimal distance) => distance * 8;
    }
}
