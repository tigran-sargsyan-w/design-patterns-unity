using UnityEngine;

namespace FlyweightPattern
{
    public class FlyweightTest : MonoBehaviour
    {
        private void Start()
        {
            Enemy enemy = new Enemy();
            enemy.ShowStats();
            enemy.TakeDamage(50);
            enemy.ShowStats();
        }
    }
}