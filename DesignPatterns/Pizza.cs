namespace DesignPatterns
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public override string ToString()
        {
            return $"Pizza with {Dough} dough, {Sauce} sauce and {Topping} topping. Mmm.";
        }
    }

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
    }
}