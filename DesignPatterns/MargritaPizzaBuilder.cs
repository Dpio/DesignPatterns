namespace DesignPatterns
{
    public class MargritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.Dough = "thin";
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "mild";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = new[] { "none" };
        }
    }
}