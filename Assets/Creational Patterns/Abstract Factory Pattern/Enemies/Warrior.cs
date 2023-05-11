using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Warrior : MonoBehaviour, IEnemy
    {
        public string EnemyName { get; set; }
        public void Init()
        {
            EnemyName = "Warrior";
            Debug.Log($"{EnemyName} created");
        }
    }
}