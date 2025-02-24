using GCHFDPE.DecoratingObjects.AbstractClasses;

namespace GCHFDPE.DecoratingObjects.Classes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(Size size)
        {
            _description = "House Blend";
            this.SetSize(size);
        }

        public override double Cost()
        {
            return 2.60;
        }
    }
}
