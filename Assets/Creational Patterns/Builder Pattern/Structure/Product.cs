namespace BuilderPattern
{
    public abstract class Product
    {
        public abstract string   Name { get; }
        public abstract string   Type { get; }
        public abstract int   Price { get; }
    }
}