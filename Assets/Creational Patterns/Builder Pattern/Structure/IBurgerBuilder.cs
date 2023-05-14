namespace BuilderPattern
{
    public interface IBurgerBuilder
    {
        void AddPart1();
        void AddPart2();
        void AddPart3();
        Product GetProduct();
    }
}