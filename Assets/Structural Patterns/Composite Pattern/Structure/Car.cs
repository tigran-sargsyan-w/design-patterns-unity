using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern
{
    public class Car : Device
    {
        List<Device> devices = new List<Device>();
        
        public override void Add(Device device)
        {
            devices.Add(device);
        }

        public override void Remove(Device device)
        {
            devices.Remove(device);
        }

        public override void Display()
        {
            Debug.Log("It's a car and it has: ");
            foreach (var device in devices) device.Display();
        }
    }
}