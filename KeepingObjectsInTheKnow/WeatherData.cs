using System;

namespace GCHFDPE.KeepingObjectsInTheKnow
{
    public class WeatherData : ISubject
    {
        private IList<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        /*
         * Acts as reading weather data off a device
         * Todo: Read weather data off the web for fun!
        */
        public void SetMeasurements()
        {
            Random rand = new Random();
            this._temperature = (float)rand.NextDouble();
            this._humidity = (float)rand.NextDouble() * 105;
            this._pressure = (float)(rand.NextDouble() * 1.5);
            MeasurementsChanged();
        }
    }
}
