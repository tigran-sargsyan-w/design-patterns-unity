using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Wraith : MonoBehaviour , IEnemy
    {
        public string EnemyName { get; set; }
        public void Init()
        {
            EnemyName = "Wraith";
            Debug.Log($"{EnemyName} created");
        }
    }
}