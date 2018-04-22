namespace DesignPatterns
{
    public abstract class PizzaBuilder
    {
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