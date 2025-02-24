using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.Classes
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(Size size)
        {
            _description = "Dark Roast";
            this.SetSize(size);
        }

        public override double Cost()
        {
            return 2.12;
        }
    }
}
