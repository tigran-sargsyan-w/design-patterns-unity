using UnityEngine;

namespace StrategyPattern
{
    public class DefensiveBehavior : IEnemyBehavior
    {
        public void Move()
        {
            Debug.Log("Defensive move");
        }

        public void Attack()
        {
            Debug.Log("Defensive attack");
        }
    }
}