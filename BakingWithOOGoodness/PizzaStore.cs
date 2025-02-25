using GCHFDPE.BakingWithOOGoodness.Interfaces;

namespace GCHFDPE.BakingWithOOGoodness
{
    public class PizzaStore
    {
        SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza = _factory.CreatePizza(type); //avoids concrete (new keyword) instantiations

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return null;
        }
    }
}
