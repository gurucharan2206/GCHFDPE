using GCHFDPE.BakingWithOOGoodness.Classes;
using GCHFDPE.BakingWithOOGoodness.Interfaces;

namespace GCHFDPE.BakingWithOOGoodness
{
    public class SimplePizzaFactory
    {
        /*
         * DP: 
         */

        /*

        FACTORY PATTERN: 
        Factory and Client
            - Create products (objects) without exposing instantiation logic to client
        */

        /*
         * We can have multiple "Clients" (like PizzaStore here) relying on this SimplePizzaFactory,
         * So by "encapsulating" pizza creation in this class, we only need to make any modifications here
         * Factory handles instantiation part with help of concrete class and hands over "products" to client
        */

        /*
         * If defined by static method, then it's a Static Factory
         * in static factory we don't have to instantiate object to use create method
         * but disadavantages are we can't subclass and change behavior of create method ---good right? close to modification -> ASK
         */
        public IPizza CreatePizza(string type)
        {
            IPizza? pizza = null;

            if (type.Equals("Cheeze"))
            {
                pizza = new CheezePizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("Veggie"))
            {
                pizza = new VeggiePizza();
            }

            if(pizza == null)
            {
                throw new Exception("Pizza category is not found in factory");
            }

            return pizza;
        }
    }
}
