using GCHFDPE.DesignPatternIntro;
using GCHFDPE.DesignPatternIntro.Classes;
using GCHFDPE.DesignPatternIntro.Classes.Ducks;
using GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;
using GCHFDPE.KeepingObjectsInTheKnow;
using GCHFDPE.KeepingObjectsInTheKnow.Classes;
using GCHFDPE.KeepingObjectsInTheKnow.Classes.DisplayElements;
using GCHFDPE.KeepingObjectsInTheKnow.Interfaces;

class Program
{
    public static void Main(string[] args)
    {
        /*
         * Chapter 1
         */
        //var simulator = new MiniDuckSimulator();
        //simulator.SimulateDucks();

        /*
         * Chapter 2
         */
        var weatherStation = new WeatherStation();
        weatherStation.SimulateWeatherStation();

        //var hospital = new Hospital();
        //hospital.SimulatePatientNotification();
    }
}

//Chapter 1
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

//Chapter 2
public class WeatherStation
{
    public void SimulateWeatherStation()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
    }
}

public class Hospital
{
    public void SimulatePatientNotification()
    {
        HealthCareNotifier healthCareNotifier = new HealthCareNotifier();
        healthCareNotifier.PageDepartments += healthCareNotifier.Cardiology;
        healthCareNotifier.PageDepartments += healthCareNotifier.Nurse;

        //Lambda expression with Action (predefined delegate type)
        Action wardGuard = () =>
        {
            Console.WriteLine("Ward alert!");
        };

        // Action is a predefined delegate type in C# that doesn’t match the signature of the event handler for PageDepartments
        // Action delegate doesn't directly match the event handler type (PageDepartments), so we invoke the Action within the event subscription.
        healthCareNotifier.PageDepartments += () => wardGuard(); //invoke action within event subscription to avoid delegate type compatilbility issue
        healthCareNotifier.PageDepartments += () =>
        {
            Console.WriteLine("Stand-by for OT alert to management");
        };

        healthCareNotifier.PatientMetricMonitor();
    }
}