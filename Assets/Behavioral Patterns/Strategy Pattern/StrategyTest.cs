using UnityEngine;

namespace StrategyPattern
{
    public class StrategyTest : MonoBehaviour
    {
        private void Start()
        {
            Enemy enemy = new Enemy();
            enemy.SetBehavior(new DefensiveBehavior());
            enemy.Move();
            
            enemy.SetBehavior(new AggressiveBehavior());
            enemy.Attack();
        }
    }
}