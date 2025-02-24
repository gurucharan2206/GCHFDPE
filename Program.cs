using GCHFDPE.DecoratingObjects;
using GCHFDPE.DecoratingObjects.AbstractClasses;
using GCHFDPE.DecoratingObjects.Classes;
using GCHFDPE.DecoratingObjects.ConcreteDecorators;
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
        //var weatherStation = new WeatherStation();
        //weatherStation.SimulateWeatherStation();

        //var hospital = new Hospital();
        //hospital.SimulatePatientNotification();

        /*
         * Chapter 3
         */
        //var starBuzzCoffee = new StarBuzzCoffee();
        //starBuzzCoffee.SimulateCoffeeOrders();

        var fileStreamReader = new FileStreamReader();
        fileStreamReader.SimulateReader();
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
        AvgMaxMinDisplay avgMaxMinDisplay = new AvgMaxMinDisplay(weatherData);
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

//Chapter 3
public class StarBuzzCoffee
{
    public void SimulateCoffeeOrders()
    {
        Beverage beverage = new Espresso(Beverage.Size.Tall);
        Console.WriteLine($"{beverage.GetDescription()} Cost: ${beverage.Cost()}");

        Beverage beverage2 = new DarkRoast(Beverage.Size.Venti);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} Cost: ${beverage2.Cost()}");

        Beverage beverage3 = new HouseBlend(Beverage.Size.Grande);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Soy(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.GetDescription()} Cost: ${beverage3.Cost()}");
    }
}

public class FileStreamReader
{
    public void SimulateReader()
    {
        using (var sr = new StreamReader("C:\\Users\\guruc\\source\\repos\\GCHeadFirstDesginPatternsExploration\\DecoratingObjects\\decorator_test.txt"))
        {
            var line = string.Empty;
            var lowerSr = new UpperCaseInputStream(sr);

            while ((line = lowerSr.ReadLine()) != null)
            {
                Console.WriteLine("***********");
                Console.WriteLine(line);
                Console.WriteLine("***********");
            }
        }
    }
}