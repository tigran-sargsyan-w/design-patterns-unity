namespace BuilderPattern
{
    public class FluentBurgerBuilder : IFluentBurgerBuilder
    {
        private Burger burger;
        
        public IFluentBurgerBuilder Cook(string meatType)
        {
            burger = new Burger(meatType);
            return this;
        }

        public IFluentBurgerBuilder AddMustard()
        {
            burger.Add("Mustard");
            return this;
        }

        public IFluentBurgerBuilder AddKetchup()
        {
            burger.Add("Ketchup");
            return this;
        }

        public IFluentBurgerBuilder AddMayo()
        {
            burger.Add("Mayo");
            return this;
        }

        public IFluentBurgerBuilder AddOnion()
        {
            burger.Add("Onion");
            return this;
        }

        public IFluentBurgerBuilder AddPickle()
        {
            burger.Add("Pickle");
            return this;
        }

        public Product GetBurger()
        {
            return burger;
        }
    }
}