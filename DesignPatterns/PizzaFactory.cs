namespace DesignPatterns
{
    public class PizzaFactory
    {
        public Pizza Create(string type)
        {
            switch (type)
            {
                case "hawaiian":
                    var hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
                    var hawaii = hawaiianPizzaBuilder.Build();
                    return hawaii;
                case "spicy":
                    var spicyPizzaBuilder = new SpicyPizzaBuilder();
                    var spicy = spicyPizzaBuilder.Build();
                    return spicy;
                default:
                    var margritaPizzaBuilder = new MargritaPizzaBuilder();
                    var pizza = margritaPizzaBuilder.Build();
                    return pizza;
            }
        }
    }
}