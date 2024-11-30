using GCHFDPE.DesignPatternIntro;
using GCHFDPE.DesignPatternIntro.Classes;
using GCHFDPE.DesignPatternIntro.Classes.Ducks;
using GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;

class Program
{
    public static void Main(string[] args)
    {
        var simulator = new MiniDuckSimulator();
        simulator.SimulateDucks();
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