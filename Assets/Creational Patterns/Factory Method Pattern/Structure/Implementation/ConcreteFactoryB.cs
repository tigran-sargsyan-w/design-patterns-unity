namespace FactoryMethodPattern
{
   public class ConcreteFactoryB : IFactory
   {
       public IProduct FactoryMethod()
       {
           return new ConcreteProductB();
       }
   } 
}
