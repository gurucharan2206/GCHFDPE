using System;
using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes
{
    public class WeatherData : ISubject
    {
        /* DP:
        * Strive for loosely coupled designs between objects that interact
        *       Allows us to build flexible OO systems that can handle change because they
        *       minimize the interdependency between objects
        */

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
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public string MeasurementsChanged()
        {
            NotifyObservers();
            return "Measurements Changed";
        }

        /*
         * Acts as reading weather data off a device
         * Todo: Read weather data off the web for fun!
        */
        public void SetMeasurements()
        {
            Random rand = new Random();
            _temperature = (float)rand.NextDouble();
            _humidity = (float)rand.NextDouble() * 105;
            _pressure = (float)(rand.NextDouble() * 1.5);
            MeasurementsChanged();
        }
    }
}
