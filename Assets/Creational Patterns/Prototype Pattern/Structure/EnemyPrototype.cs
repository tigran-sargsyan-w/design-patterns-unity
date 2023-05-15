namespace PrototypePattern
{
    public abstract class EnemyPrototype
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        
        public EnemyPrototype(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        
        public abstract EnemyPrototype Clone();
        public abstract EnemyPrototype DeepClone(string name, int health, int damage);
    }
}