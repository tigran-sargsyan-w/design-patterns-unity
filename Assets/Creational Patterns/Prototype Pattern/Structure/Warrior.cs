using UnityEngine;

namespace PrototypePattern
{
    public class Warrior : EnemyPrototype
    {
        public Warrior(string name, int health, int damage) : base(name, health, damage)
        {
            
        }

        public override EnemyPrototype Clone()
        {
            Debug.Log($"<color=yellow>Prototype Memberwise-Cloned</color>");
            return (EnemyPrototype) this.MemberwiseClone();
        }

        public override EnemyPrototype DeepClone(string name = "Warrior", int health = 100, int damage = 10)
        {
            Debug.Log($"<color=yellow>Prototype Deep-Cloned</color>");
            var clone = (EnemyPrototype) this.MemberwiseClone();
            clone.Name = name;
            clone.Health = health;
            clone.Damage = damage;
            return clone;
        }
    }
}