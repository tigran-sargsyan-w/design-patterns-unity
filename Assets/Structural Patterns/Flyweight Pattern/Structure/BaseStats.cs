namespace FlyweightPattern
{
    public class BaseStats
    {
        public int MaxHealth => maxHealth;
        public int Attack => attack;
        public int Defense => defense;
        public int Speed => speed;

        private int maxHealth = 100;
        private int attack = 10;
        private int defense = 20;
        private int speed = 5;
    }
}