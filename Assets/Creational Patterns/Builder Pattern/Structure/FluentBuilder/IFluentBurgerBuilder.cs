namespace BuilderPattern
{
    public interface IFluentBurgerBuilder
    {
        IFluentBurgerBuilder Cook(string meatType);
        IFluentBurgerBuilder AddMustard();
        IFluentBurgerBuilder AddKetchup();
        IFluentBurgerBuilder AddMayo();
        IFluentBurgerBuilder AddOnion();
        IFluentBurgerBuilder AddPickle();
        Product GetBurger();
    }
}