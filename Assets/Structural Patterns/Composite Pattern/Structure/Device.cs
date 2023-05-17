namespace CompositePattern
{
    public abstract class Device
    {
        public abstract void Add(Device device);
        public abstract void Remove(Device device);
        public abstract void Display();
    }
}