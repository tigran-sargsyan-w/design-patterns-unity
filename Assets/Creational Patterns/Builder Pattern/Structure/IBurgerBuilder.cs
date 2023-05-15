namespace BuilderPattern
{
    public interface IBurgerBuilder
    {
        void Cook(string meatType);
        void AddMustard();
        void AddKetchup();
        void AddMayo();
        void AddOnion();
        void AddPickle();
        Product GetBurger();
    }
}