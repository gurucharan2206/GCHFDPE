using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors
{
    public class Squeak: QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
