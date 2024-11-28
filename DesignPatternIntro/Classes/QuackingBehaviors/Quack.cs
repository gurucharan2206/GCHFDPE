using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors
{
    public class Quack: QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Quack");
        }
    }
}
