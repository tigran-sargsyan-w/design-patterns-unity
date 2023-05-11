using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Lich : MonoBehaviour, IEnemy
    {
        public string EnemyName { get; set; }
        public void Init()
        {
            EnemyName = "Lich";
            Debug.Log($"{EnemyName} created");
        }
    }
}