namespace DesignPatterns
{
    public abstract class PizzaBuilder
    {
        protected PizzaBuilder()
        {
            Pizza = new Pizza();
        }

        protected Pizza Pizza;
        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();

        public virtual Pizza Build()
        {
            return Pizza;
        }
    }
}