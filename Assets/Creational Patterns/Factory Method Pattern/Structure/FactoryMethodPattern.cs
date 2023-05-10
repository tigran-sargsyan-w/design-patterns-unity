using UnityEngine;

namespace FactoryMethodPattern
{
    public class FactoryMethodPattern : MonoBehaviour
    {
        private void Start()
        {
            // An array of factories
            IFactory[] factories = new IFactory[2];
    
            factories[0] = new ConcreteFactoryA();
            factories[1] = new ConcreteFactoryB();
    
            // Iterate over factory and create products
            foreach (IFactory factory in factories)
            {
                IProduct product = factory.FactoryMethod();
                Debug.Log($"Created {product.Name}");
                product.Init();
            }
        }
    }
}
