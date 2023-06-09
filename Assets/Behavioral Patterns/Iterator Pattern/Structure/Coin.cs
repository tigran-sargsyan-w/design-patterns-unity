using UnityEngine;

namespace IteratorPattern
{
    public class Coin
    {
        private int value;

        public Coin(int value)
        {
            this.value = value;
        }
        
        public void DisplayValue()
        {
            Debug.Log(value);
        }
    }
}