using UnityEngine;

namespace AbstractFactoryPattern
{
    public class WarriorFactory : EnemyFactory
    {
        [SerializeField] private Warrior warriorPrefab;
        
        public override IEnemy GetEnemy(Vector3 position,Transform parent)
        {
            var enemy = Instantiate(warriorPrefab, position, Quaternion.identity,parent);
            enemy.Init();
            return enemy;
        }
    }
}