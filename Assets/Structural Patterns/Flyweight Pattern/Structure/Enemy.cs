using UnityEngine;

namespace FlyweightPattern
{
    public class Enemy
    {
        private BaseStats stats;
        private int currentHealth;

        public Enemy()
        {
            stats = new BaseStats();
            currentHealth = stats.MaxHealth;
        }

        public void ShowStats()
        {
            Debug.Log($"Enemy Stats: Attack: {stats.Attack}, Defense: {stats.Defense}, Speed: {stats.Speed}");   
            Debug.Log($"Enemy Health: {currentHealth}, Max Health: {stats.MaxHealth}");
        }
        
        public void TakeDamage(int damage)
        {
            Debug.Log($"<color=red>Enemy took {damage} damage</color>");
            currentHealth -= damage;
        }
    }
}