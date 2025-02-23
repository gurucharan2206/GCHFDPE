using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.ConcreteDecorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
