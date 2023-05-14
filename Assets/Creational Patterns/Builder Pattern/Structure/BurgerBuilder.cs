namespace BuilderPattern
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger burger;
        
        public void Cook(string meatType)
        {
            burger = new Burger(meatType);
        }

        public void AddMustard()
        {
            burger.Add("Mustard");
        }

        public void AddKetchup()
        {
            burger.Add("Ketchup");
        }

        public void AddMayo()
        {
            burger.Add("Mayo");
        }

        public void AddOnion()
        {
            burger.Add("Onion");
        }

        public void AddPickle()
        {
            burger.Add("Pickle");
        }

        public Product GetBurger()
        {
            return burger;
        }
    }
}