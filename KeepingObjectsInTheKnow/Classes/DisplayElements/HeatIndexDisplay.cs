using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class HeatIndexDisplay : IDisplayElement, IObserver
    {
        public float _apparentTemperature { get; set; }
        public WeatherData _weatherData { get; set; }

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this._apparentTemperature = _weatherData.Temperature / (_weatherData.Temperature +_weatherData.Humidity);
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@$"Heat Index: {this._apparentTemperature} ");
        }
    }
}
