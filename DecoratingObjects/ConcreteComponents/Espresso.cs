using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.Classes
{
    public class Espresso : Beverage
    {
        public Espresso(Size size)
        {
            _description = "Espresso";
            this.SetSize(size);
        }

        public override double Cost()
        {
            return 1.55;
        }
    }
}
