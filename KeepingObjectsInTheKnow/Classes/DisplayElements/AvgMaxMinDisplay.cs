using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;
using WeatherProperties = GCHFDPE.KeepingObjectsInTheKnow.Classes.Utils.Constants.WeatherProperties;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class AvgMaxMinDisplay : IObserver, IDisplayElement
    {
        //To Do: Avoid hardcoded properties manipulation here for each property. Make it generic!
        private float _averageTemperature;
        private float _averageHumidity;
        private float _averagePressure;
        private float _maxTemperature;
        private float _maxHumidity;
        private float _maxPressure;
        private float _minTemperature;
        private float _minHumidity;
        private float _minPressure;
        private WeatherData _weatherData;

        public AvgMaxMinDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            List<float> historicalTemperature = _weatherData.HistoricalMeasurements(WeatherProperties.Temperature);
            this._averageTemperature = historicalTemperature.Average();
            this._maxTemperature = historicalTemperature.Max();
            this._minTemperature = historicalTemperature.Min();

            List<float> historicalHumidity = _weatherData.HistoricalMeasurements(WeatherProperties.Humidity);
            this._averageHumidity = historicalHumidity.Average();
            this._maxHumidity = historicalHumidity.Max();
            this._minHumidity = historicalHumidity.Min();

            List<float> historicalPressure = _weatherData.HistoricalMeasurements(WeatherProperties.Pressure);
            this._averagePressure = historicalPressure.Average();
            this._maxPressure = historicalPressure.Max();
            this._minPressure = historicalPressure.Min();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"AvgMinMax: Temperature {_averageTemperature}/{_maxTemperature}/{_minTemperature}");
            Console.WriteLine($"AvgMinMax: Humidity {_averageHumidity}/{_maxHumidity}/{_minHumidity}");
            Console.WriteLine($"AvgMinMax: Pressure {_averagePressure}/{_maxPressure}/{_minPressure}");
        }
    }
}
