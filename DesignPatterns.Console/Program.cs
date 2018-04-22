namespace DesignPatterns.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();
            HawaiianPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            SpicyPizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();

            cook.MakePizza(hawaiianPizzaBuilder);
            System.Console.WriteLine(cook.OpenPizza());

            cook.MakePizza(spicyPizzaBuilder);
            System.Console.WriteLine(cook.OpenPizza());
            
            System.Console.WriteLine(cook.MakePizza("spicy"));
        }
    }
}
