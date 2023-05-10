namespace FactoryMethodPattern
{
    public class ConcreteFactoryA : IFactory
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
