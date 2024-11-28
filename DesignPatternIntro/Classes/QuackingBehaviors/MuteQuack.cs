using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors
{
    public class MuteQuack: QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
