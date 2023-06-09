using UnityEngine;

namespace StrategyPattern
{
    public class AggressiveBehavior : IEnemyBehavior
    {
        public void Move()
        {
            Debug.Log("Aggressive move");
        }

        public void Attack()
        {
            Debug.Log("Aggressive attack");
        }
    }
}