using GCHFDPE.DesignPatternIntro.Classes;
using GCHFDPE.DesignPatternIntro.Classes.Ducks;
using GCHFDPE.DesignPatternIntro.Classes.QuackingBehaviors;
using GCHFDPE.DesignPatternIntro.Interfaces;

namespace GCHFDPE.DesignPatternIntro
{
    public class DuckCall
    {
        public Duck duck; //Has-A is better than Is-A; Favor Composition over inheritance

        public DuckCall()
        {
            duck = new MallardDuck();
        }

        public void SetDuckType(Duck duckType)
        {
            duck = duckType;    //delegate the duck type to Duck
        }

        public void SetQuackType(QuackBehavior qb)
        {
            duck.SetQuackingBehavior(qb);
        }
    }
}
