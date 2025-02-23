using System;
using GCHFDPE.KeepingObjectsInTheKnow.Classes.Utils;
using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;
using static GCHFDPE.KeepingObjectsInTheKnow.Classes.Utils.Constants;

namespace GCHFDPE.KeepingObjectsInTheKnow.Classes
{
    public class WeatherData : ISubject
    {
        /* DP:
        * Strive for loosely coupled designs between objects that interact
        *       Allows us to build flexible OO systems that can handle change because they
        *       minimize the interdependency between objects
        */

        /*
         * Pushing for Subject: notifications so far to all observers, now let observers pull data they need!
         * Pulling for Observers: is implemented by using getter methods from weather data inside observers
         */

        /*
         
        OBSERVER PATTERN:
            Defines a one-to-many dependency, 
            -   between objects so that when one object changes state,
            -   all its dependents are notified and updated automatically

        Communicate state to set of objects in a loosely coupled manner

        */

        private IList<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private List<float> _historicalTemperatures = new List<float>();
        private List<float> _historicalHumidities = new List<float>();
        private List<float> _historicalPressures = new List<float>();

        public float Temperature
        {
            get { return _temperature; }
        }
        public float Humidity
        {
            get { return _humidity; }
        }

        public float Pressure
        {
            get { return _pressure; }
        }

        public List<float> HistoricalMeasurements(Constants.WeatherProperties property)
        {
            switch (property)
            {
                case Constants.WeatherProperties.Temperature:
                    return _historicalTemperatures;
                case Constants.WeatherProperties.Humidity:
                    return _historicalHumidities;
                case Constants.WeatherProperties.Pressure:
                    return _historicalPressures;
                default:
                    return new List<float>();
            }
        }

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
                observer.Update();
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

            _historicalTemperatures.Add(_temperature);
            _historicalHumidities.Add(_humidity);
            _historicalPressures.Add(_pressure);

            MeasurementsChanged();
        }
    }
}
