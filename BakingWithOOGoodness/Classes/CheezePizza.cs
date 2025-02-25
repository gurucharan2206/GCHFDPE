using GCHFDPE.BakingWithOOGoodness.Interfaces;

namespace GCHFDPE.BakingWithOOGoodness.Classes
{
    public class CheezePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("CheezePizza Bake");
        }

        public void Box()
        {
            Console.WriteLine("CheezePizza Box");
        }

        public void Cut()
        {
            Console.WriteLine("CheezePizza Cut");
        }

        public void Prepare()
        {
            Console.WriteLine("CheezePizza Prepare");
        }
    }
}
