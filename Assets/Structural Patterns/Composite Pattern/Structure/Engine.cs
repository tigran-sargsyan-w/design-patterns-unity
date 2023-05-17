using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern
{
    public class Engine : Device
    {
        List<Device> engineDetails = new List<Device>();
        
        public override void Add(Device device)
        {
            engineDetails.Add(device);
        }

        public override void Remove(Device device)
        {
            engineDetails.Remove(device);
        }

        public override void Display()
        {
            Debug.Log("It's an engine and it has: ");
            foreach (var detail in engineDetails) detail.Display();
        }
    }
}