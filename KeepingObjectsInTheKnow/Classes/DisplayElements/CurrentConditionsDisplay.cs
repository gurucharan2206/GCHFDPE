using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;
using GCHFDPE.KeepingObjectsInTheKnow.Classes;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature { get; set; }
        private float _humidity { get; set; }
        private float _pressure { get; set; }
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this._temperature = _weatherData.Temperature;
            this._humidity = _weatherData.Humidity;
            this._pressure = _weatherData.Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@$"Current conditions THP: {_temperature} {_humidity} {_pressure}");
        }
    }
}
