namespace DesignPatterns
{
    public class PizzaFactory
    {
        public Pizza Create(string type)
        {
            switch (type)
            {
                case "hawaiian":
                    var hawaii = new HawaiianPizzaBuilder().Build();
                    return hawaii;
                case "spicy":
                    var spicy = new SpicyPizzaBuilder().Build();
                    return spicy;
                default:
                    var pizza = new MargritaPizzaBuilder().Build();
                    return pizza;
            }
        }
    }
}