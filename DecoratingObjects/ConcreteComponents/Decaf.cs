using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.Classes
{
    public class Decaf : Beverage
    {
        public Decaf(Size size)
        {
            _description = "Decaf";
            this.SetSize(size);
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
