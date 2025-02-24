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
            var condimentCost = 0.00;
            switch (_beverage.GetSize())
            {
                case Size.Tall:
                    condimentCost = 1.50;
                    break;
                case Size.Grande:
                    condimentCost = 2.50;
                    break;
                case Size.Venti:
                    condimentCost = 2.75;
                    break;
                default:
                    break;
            }

            return _beverage.Cost() + condimentCost;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
