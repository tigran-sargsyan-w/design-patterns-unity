using System.Collections.Generic;
using UnityEngine;

namespace BuilderPattern
{
    public class Burger : Product
    {
        private List<string> parts = new ();
        
        public override string Name { get; }
        public override string Type { get; }
        public override int Price { get; }
        

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Debug.Log("\nBurger Parts -------");
            foreach (string part in parts) Debug.Log(part);
        }
    }
}