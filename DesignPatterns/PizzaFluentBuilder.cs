using System.Linq;

namespace DesignPatterns
{
    public class PizzaFluentBuilder
    {
        protected Pizza Pizza;

        protected PizzaFluentBuilder()
        {
            Pizza = new Pizza();
        }

        public PizzaFluentBuilder BuildDough(string dough)
        {
            Pizza.Dough = dough;
            return this;
        }

        public PizzaFluentBuilder BuildSauce(string souce)
        {
            Pizza.Sauce = souce;
            return this;
        }

        public PizzaFluentBuilder BuildTopping(string tapping)
        {
            Pizza.Topping.ToList().Add(tapping);
            return this;
        }

        public PizzaFluentBuilder BuildTopping(string[] tappings)
        {
            Pizza.Topping = tappings;
            return this;
        }

        public virtual Pizza Build()
        {
            return Pizza;
        }
    }
}