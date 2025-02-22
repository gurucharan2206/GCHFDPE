using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;
using GCHFDPE.KeepingObjectsInTheKnow.Classes;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature { get; set; }
        private float _humidity { get; set; }
        public float _pressure { get; set; }
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@$"Current conditions THP: {_temperature} {_humidity} {_pressure}");
        }
    }
}
