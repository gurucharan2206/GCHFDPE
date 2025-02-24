using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.ConcreteDecorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.02;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
