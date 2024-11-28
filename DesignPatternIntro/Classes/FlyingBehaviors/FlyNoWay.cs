using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly, but I'm happy being on ground too!");
        }
    }
}
