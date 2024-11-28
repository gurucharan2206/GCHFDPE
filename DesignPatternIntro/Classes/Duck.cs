using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes
{
    public abstract class Duck
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public Duck()
        {
            
        }

        public abstract void Display(); //abstract methods do not have body

        public void PerformFly()
        {
            flyBehavior.Fly(); //delegating to behavior class
        }

        public void PerformQuack()
        {
            quackBehavior.QuackSound(); //delegating to behavior class
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!"); //separate what stays from what changes!!!
        }
    }
}