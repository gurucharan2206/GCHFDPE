using GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;

namespace GCHFDPE.DesignPatternIntro.Classes.Ducks
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack(); //now that base class has "public" keyword, we can use them here
            flyBehavior = new FlyWithWings();
        }

        public override void Display() //override keyword to override abstract method and provide concrete implementation
        {
            Console.WriteLine("I'm mallard duck!");
        }
    }
}
