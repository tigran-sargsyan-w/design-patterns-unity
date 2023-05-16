using UnityEngine;

namespace AdapterPattern
{
    public class AdapterTest : MonoBehaviour
    {
        private void Start()
        {
            IEnemy enemyAdapter = new EnemyAdapter();
            enemyAdapter.Attack();
            enemyAdapter.Defend();
        }
    }
}