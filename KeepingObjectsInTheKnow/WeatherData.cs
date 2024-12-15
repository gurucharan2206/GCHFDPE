namespace GCHFDPE.KeepingObjectsInTheKnow
{
    public class WeatherData
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public float GetTemperature()
        {
            Random rand = new Random();
            _temperature = (float)rand.NextDouble();
            return _temperature;
        }

        public float GetHumidity()
        {
            Random rand = new Random();
            _humidity = (float)rand.NextDouble();
            return _humidity;
        }

        public float GetPressure()
        {
            Random rand = new Random();
            _pressure = (float)rand.NextDouble();
            return _pressure;
        }

        public string MeasurementsChanged()
        {
            float temp = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();

            return $"{temp} {humidity} {pressure}";
        }
    }
}
