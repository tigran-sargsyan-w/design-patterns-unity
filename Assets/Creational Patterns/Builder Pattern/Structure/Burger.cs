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

        public Burger(string meatType)
        {
            Name = "Burger";
            Type = meatType;
        }
        
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            string partsText = $"Your <color=red>{Type}: </color> Burger has an extra:  ";
            foreach (var part in parts) partsText += part + ", ";
            Debug.Log(partsText);
        }
    }
}