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
            var condimentCost = 0.00;
            switch (_beverage.GetSize())
            {
                case Size.Tall:
                    condimentCost = 2.50;
                    break;
                case Size.Grande:
                    condimentCost = 0.50;
                    break;
                case Size.Venti:
                    condimentCost = 1.25;
                    break;
                default:
                    break;
            }

            //delegate cost to object we're decorating and add Mocha cost on top of it
            return _beverage.Cost() + condimentCost;
        }

        public override string GetDescription()
        {
            //_description = "__"; interesting, in C# protected level is accessible by grand children too!
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
