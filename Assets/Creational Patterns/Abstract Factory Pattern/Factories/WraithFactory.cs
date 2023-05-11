using UnityEngine;

namespace AbstractFactoryPattern
{
    public class WraithFactory : EnemyFactory
    {
        [SerializeField] private Wraith wraithPrefab;
        
        public override IEnemy GetEnemy(Vector3 position,Transform parent)
        {
            var enemy = Instantiate(wraithPrefab, position, Quaternion.identity,parent);
            enemy.Init();
            return enemy;
        }
    }
}