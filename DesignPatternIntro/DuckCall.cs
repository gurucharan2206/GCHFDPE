using GCHFDPE.DesignPatternIntro.Classes;
using GCHFDPE.DesignPatternIntro.Classes.Ducks;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;
using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro
{
    public class DuckCall
    {
        public Duck duck;
        public QuackBehavior quackBehavior;

        public DuckCall()
        {
            duck = new MallardDuck();
            quackBehavior = new Quack();
        }

        public void SetDuckType(Duck duckType)
        {
            duck = duckType;
        }

        public void SetQuackType(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

    }
}
