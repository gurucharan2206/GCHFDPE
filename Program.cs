using GCHFDPE.DesignPatternIntro.Classes;
using GCHFDPE.DesignPatternIntro.Classes.Ducks;
using GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors;

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
    }
}