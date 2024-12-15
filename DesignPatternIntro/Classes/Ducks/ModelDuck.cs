using GCHFDPE.DesignPatternIntro.Classes.FlyingBehaviors;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;

namespace GCHFDPE.DesignPatternIntro.Classes.Ducks
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
