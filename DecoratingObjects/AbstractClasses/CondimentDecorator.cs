namespace GCHFDPE.DecoratingObjects.AbstractClasses
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public abstract string GetDescription();
    }
}
