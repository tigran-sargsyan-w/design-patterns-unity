using UnityEngine;

namespace FactoryMethodPattern
{
    public class ConcreteProductA : IProduct
    {
        private string name = "ConcreteProductA";
        
        public string Name
        {
            get => name;
            set => name = value;
        }
    
        public void Init()
        {
            Debug.Log("ProductA.Init()");
        }
    }
}
