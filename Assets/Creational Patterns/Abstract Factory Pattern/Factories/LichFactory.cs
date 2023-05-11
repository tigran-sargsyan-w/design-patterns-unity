using UnityEngine;

namespace AbstractFactoryPattern
{
    public class LichFactory : EnemyFactory
    {
        [SerializeField] private Lich lichPrefab;
        
        public override IEnemy GetEnemy(Vector3 position, Transform parent)
        {
            var enemy = Instantiate(lichPrefab, position, Quaternion.identity,parent);
            enemy.Init();
            return enemy;
        }
    }
}