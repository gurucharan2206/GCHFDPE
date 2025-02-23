using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class StatisticsDisplay: IDisplayElement, IObserver
    {
        private float _percentHumidity { get; set; }
        private float _percentTemperature { get; set; }
        private float _percentPressure { get; set; }
        private WeatherData _weatherData { get; set; }

        public StatisticsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            var sumForStats = _weatherData.Temperature + _weatherData.Humidity + _weatherData.Pressure;
            this._percentTemperature = _weatherData.Temperature / (sumForStats);
            this._percentHumidity = _weatherData.Humidity / (sumForStats);
            this._percentPressure = _weatherData.Pressure / (sumForStats);
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@$"Stats: {this._percentTemperature} {this._percentHumidity} {this._percentPressure}");
        }
    }
}
