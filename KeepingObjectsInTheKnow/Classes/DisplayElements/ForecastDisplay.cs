using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        public float _forecastHumidity { get; set; }
        public float _forecastTemperature { get; set; }
        public float _forecastPressure { get; set; }
        public WeatherData _weatherData { get; set; }

        public ForecastDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this._forecastTemperature = temp + 50;
            this._forecastHumidity = humidity + 50;
            this._forecastPressure = pressure + 50;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@$"Forecast: {this._forecastTemperature} {this._forecastHumidity} {this._forecastPressure}");
        }
    }
}
