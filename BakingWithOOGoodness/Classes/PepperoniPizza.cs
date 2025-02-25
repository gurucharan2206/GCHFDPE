using GCHFDPE.BakingWithOOGoodness.Interfaces;

namespace GCHFDPE.BakingWithOOGoodness.Classes
{
    public class PepperoniPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("PepperoniPizza Bake");
        }

        public void Box()
        {
            Console.WriteLine("PepperoniPizza Box");
        }

        public void Cut()
        {
            Console.WriteLine("PepperoniPizza Cut");
        }

        public void Prepare()
        {
            Console.WriteLine("PepperoniPizza Prepare");
        }
    }
}
