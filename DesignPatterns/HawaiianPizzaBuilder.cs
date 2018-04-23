namespace DesignPatterns
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.Dough = "cross";
        }

        public override void BuildSauce()
        {
            Pizza.Sauce = "mild";
        }

        public override void BuildTopping()
        {
            Pizza.Topping = new[] { "ham", "pineapple" };
        }
    }

    public class HawaiianPizzaFluentBuilder : PizzaFluentBuilder
    {
        public override PizzaFluentBuilder BuildDough()
        {
            Pizza.Dough = "cross";
            return this;
        }

        public override PizzaFluentBuilder BuildSauce()
        {
            Pizza.Sauce = "mild";
            return this;
        }

        public override PizzaFluentBuilder BuildTopping()
        {
            Pizza.Topping = new[] { "ham", "pineapple" };
            return this;
        }
    }
}