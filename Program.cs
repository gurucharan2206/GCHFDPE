using GCHFDPE.DesignPatternIntro;
using GCHFDPE.DesignPatternIntro.Classes;
using GCHFDPE.DesignPatternIntro.Classes.Ducks;
using GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;
using GCHFDPE.KeepingObjectsInTheKnow;
using GCHFDPE.KeepingObjectsInTheKnow.Classes;
using GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements;

class Program
{
    public static void Main(string[] args)
    {
        //Chapter 1
        //var simulator = new MiniDuckSimulator();
        //simulator.SimulateDucks();

        //Chapter 2
        var weatherStation = new WeatherStation();
        weatherStation.SimulateWeatherStation();
    }
}

public class MiniDuckSimulator
{
    public void SimulateDucks()
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.PerformFly();
        mallardDuck.PerformQuack();

        Duck modelDuck = new ModelDuck();
        modelDuck.Display();
        modelDuck.PerformFly();
        modelDuck.SetFlyingBehavior(new FlyRocketPowered());
        modelDuck.PerformFly();
        modelDuck.PerformQuack();

        DuckCall duckCall = new DuckCall();
        duckCall.duck.PerformQuack();
        duckCall.SetDuckType(new ModelDuck());
        duckCall.SetQuackType(new Squeak());
        duckCall.duck.PerformQuack();
    }
}

public class WeatherStation
{
    public void SimulateWeatherStation()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
    }
}