using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.ConcreteDecorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage; //object we are decorating
        }

        public override double Cost()
        {
            //delegate cost to object we're decorating and add Mocha cost on top of it
            return _beverage.Cost() + 0.05;
        }

        public override string GetDescription()
        {
            //_description = "__"; interesting, in C# protected level is accessible by grand children too!
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
