using UnityEngine;

namespace CompositePattern
{
    public class Flywheel : Device
    {
        public override void Add(Device device)
        {
            Debug.Log("Cannot add to a hierarchy");
        }

        public override void Remove(Device device)
        {
            Debug.Log("Cannot remove from a hierarchy");
        }

        public override void Display()
        {
            Debug.Log("Flywheel");
        }
    }
}