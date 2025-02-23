using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.Classes
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaf";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
