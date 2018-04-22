namespace DesignPatterns
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.Dough = "pan baked";
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "hot";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = new [] { "pepperoni", "salami"};
        }
    }
}