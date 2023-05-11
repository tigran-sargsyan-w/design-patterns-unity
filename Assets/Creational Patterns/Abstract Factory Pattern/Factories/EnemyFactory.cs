using UnityEngine;

namespace AbstractFactoryPattern
{
    public abstract class EnemyFactory : MonoBehaviour
    {
        public abstract IEnemy GetEnemy(Vector3 position,Transform parent = null);
    }
}