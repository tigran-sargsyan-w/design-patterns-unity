using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace AbstractFactoryPattern
{
    public class AbstractFactoryTest : MonoBehaviour
    {
        [SerializeField] private EnemyFactory[] factories;
        [SerializeField] private List<Transform> spawnPoints;
        [SerializeField] private Transform spawnParent;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (spawnPoints.Count == 0)
                {
                    Debug.Log("No more place is available!");
                    return;
                }
                EnemyFactory factory = factories[Random.Range(0, factories.Length)];
                var spawnTransform = spawnPoints[Random.Range(0, spawnPoints.Count)];
                factory.GetEnemy(spawnTransform.position, spawnParent);
                spawnPoints.Remove(spawnTransform);
            }
        }
    }
}