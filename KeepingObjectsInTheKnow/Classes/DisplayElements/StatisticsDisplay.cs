using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements
{
    public class StatisticsDisplay: IDisplayElement, IObserver
    {
        public float _percentHumidity { get; set; }
        public float _percentTemperature { get; set; }
        public float _percentPressure { get; set; }
        public WeatherData _weatherData { get; set; }

        public StatisticsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this._percentTemperature = temp / (temp + humidity + pressure);
            this._percentHumidity = humidity / (temp + humidity + pressure);
            this._percentPressure = pressure / (temp + humidity + pressure);
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@$"Stats: {this._percentTemperature} {this._percentHumidity} {this._percentPressure}");
        }
    }
}
