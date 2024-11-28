using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying, 'cause I have wings!");
        }
    }
}
