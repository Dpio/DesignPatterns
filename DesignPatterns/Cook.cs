namespace DesignPatterns
{
    public class Cook
    {
        private PizzaBuilder _pizzaBuilder;

        public string OpenPizza()
        {
            if (_pizzaBuilder == null)
            {
                return "There is no pizza!";
            }
            var pizza = _pizzaBuilder.Build();
            return pizza.ToString();
        }

        public void MakePizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}