using HomeWork_04.Drivers;
using HomeWork_04.Movements;
using HomeWork_04.TaxiFactorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04.TaxiOrders
{
    public class TaxiOrder
    {
        private readonly Driver _driver;
        private readonly Movement _movement;
        private TaxiFactorys.TaxiFactory? factory;

        public TaxiOrder(TaxiFactory factory)
        {
            _driver = factory.CreateDriver();
            _movement = factory.CreateMovement();
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Ваш заказ: {_driver.GetDescription()} {_movement.Move()}");
        }
    }
}
