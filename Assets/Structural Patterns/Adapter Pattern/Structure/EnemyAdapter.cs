using UnityEngine;

namespace AdapterPattern
{
    public class EnemyAdapter : IEnemy
    {
        SpecialEnemy specialEnemy = new SpecialEnemy();
        public void Attack()
        {
            Debug.Log("Enemy Adapter Attack");
            specialEnemy.Attack();
        }
        public void Defend()
        {
            Debug.Log("Enemy Adapter Defend");
            specialEnemy.Defend();
        }
    }
}