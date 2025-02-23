using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.Classes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }
        public override double Cost()
        {
            return 1.55;
        }
    }
}
