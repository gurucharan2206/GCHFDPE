using GCHFDPE.BakingWithOOGoodness.Interfaces;

namespace GCHFDPE.BakingWithOOGoodness.Classes
{
    public class VeggiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("VeggiePizza Bake");
        }

        public void Box()
        {
            Console.WriteLine("VeggiePizza Box");
        }

        public void Cut()
        {
            Console.WriteLine("VeggiePizza Cut");
        }

        public void Prepare()
        {
            Console.WriteLine("VeggiePizza Prepare");
        }
    }
}
