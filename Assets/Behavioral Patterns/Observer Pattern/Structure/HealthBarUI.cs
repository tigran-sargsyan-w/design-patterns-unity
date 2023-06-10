using UnityEngine;

namespace ObserverPattern
{
    public class HealthBarUI : IHealthObserver
    {
        public void OnHealthChanged(int health)
        {
            Debug.Log("Health changed: " + health);
        }
    }
}