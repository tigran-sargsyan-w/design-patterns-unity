using UnityEngine;

namespace ObserverPattern
{
    public class ObserverTest : MonoBehaviour
    {
        private PlayerHealth playerHealth = new PlayerHealth();
        private HealthBarUI healthBarUI = new HealthBarUI();

        private void OnDestroy()
        {
            playerHealth.RemoveObserver(healthBarUI);
        }

        private void Start()
        {
            playerHealth.AddObserver(healthBarUI);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerHealth.Health -= 10;
            }
        }
    }
}