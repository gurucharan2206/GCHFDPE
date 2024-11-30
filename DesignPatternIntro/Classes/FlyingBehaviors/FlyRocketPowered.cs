using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors
{
    public class FlyRocketPowered: FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying like a rocket!!");
        }
    }
}
