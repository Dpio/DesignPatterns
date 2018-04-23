namespace DesignPatterns
{
    public abstract class PizzaBuilder
    {
        protected Pizza Pizza;
        protected PizzaBuilder()
        {
            Pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();

        public virtual Pizza Build()
        {
            BuildDough();
            BuildSauce();
            BuildTopping();
            return Pizza;
        }
    }
}