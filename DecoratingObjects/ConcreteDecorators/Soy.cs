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
            var condimentCost = 0.00;
            switch (_beverage.GetSize())
            {
                case Size.Tall:
                    condimentCost = 0.19;
                    break;
                case Size.Grande:
                    condimentCost = 0.52;
                    break;
                case Size.Venti:
                    condimentCost = 3.25;
                    break;
                default:
                    break;
            }

            return _beverage.Cost() + condimentCost;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
