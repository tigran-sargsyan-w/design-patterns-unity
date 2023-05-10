using UnityEngine;

namespace FactoryMethodPattern
{
    public class ConcreteProductB : IProduct
    {
        private string name = "ConcreteProductB";
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public void Init()
        {
            Debug.Log("ProductB.Init()");
        }
    }
}