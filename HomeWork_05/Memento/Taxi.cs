using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05.State;
using HomeWork_05.Strategy;

namespace HomeWork_05.Memento
{
    public class Taxi
    {
        private ITaxiState _state;
        private ITariffStrategy _tariff;

        public string Driver { get; set; }
        public decimal Mileage { get; private set; }
        public string Number { get; }

        public Taxi(string number, string driver)
        {
            Number = number;
            Driver = driver;
            _state = new StoppedState();
            _tariff = new StandardTariff();
            Mileage = 0;
        }

        public void SetTariff(ITariffStrategy tariff) => _tariff = tariff;
        public void SetState(ITaxiState state) => _state = state;

        public void Start() => _state.Start(this);
        public void Stop() => _state.Stop(this);
        public void Accelerate() => _state.Accelerate(this);

        public decimal CalculateCost(decimal distance) => _tariff.CalculateCost(distance);
        public string GetStatus() => _state.GetStatus();

        public void AddMileage(decimal km) => Mileage += km;

        // Создание memento
        public TaxiMemento SaveState() => new TaxiMemento(Mileage, Driver, GetStatus());

        // Восстановление состояния из memento
        public void RestoreState(TaxiMemento memento)
        {
            Mileage = memento.Mileage;
            Driver = memento.Driver;

            // Восстанавливаем состояние на основе сохраненного статуса
            switch (memento.Status)
            {
                case "Стоит": _state = new StoppedState(); break;
                case "Движется": _state = new MovingState(); break;
                case "Мчится": _state = new SpeedingState(); break;
            }
        }
    }
}
