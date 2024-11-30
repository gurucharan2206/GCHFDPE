using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro.Classes
{
    public abstract class Duck
    {
        /*
         
        STRATEGY PATTERN:
            Defines a family of algorithms, 
            -   Encapsulates each one, and 
            -   Makes them INTERCHANGEABLE.

        Strategy lets the algorithm vary independently from clients that use it
            
        */

        public FlyBehavior flyBehavior;    //if no keyword, default is private access
        public QuackBehavior quackBehavior;

        public Duck()
        {
            
        }

        public abstract void Display(); //abstract methods do not have body

        public void SetFlyingBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackingBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

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