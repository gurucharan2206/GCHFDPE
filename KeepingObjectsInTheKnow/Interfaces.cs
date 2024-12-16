namespace GCHFDPE.KeepingObjectsInTheKnow
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }

    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }

    public interface IDisplayElement
    {
        public void Display();
    }
}
