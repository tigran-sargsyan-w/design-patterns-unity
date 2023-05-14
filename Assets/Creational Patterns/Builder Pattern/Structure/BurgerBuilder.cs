namespace BuilderPattern
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger burger = new Burger();

        public void AddPart1()
        {
            burger.Add("Generals");
        }

        public void AddPart2()
        {
            burger.Add("Chicken");
        }

        public void AddPart3()
        {
            burger.Add("Onion");
        }

        public Product GetProduct()
        {
            return burger;
        }
    }
}