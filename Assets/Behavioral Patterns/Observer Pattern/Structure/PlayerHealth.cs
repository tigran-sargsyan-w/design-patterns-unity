using System.Collections.Generic;

namespace ObserverPattern
{
    public class PlayerHealth
    {
        private int health;
        private List<IHealthObserver> observers = new List<IHealthObserver>();

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IHealthObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IHealthObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnHealthChanged(health);
            }
        }
    }
}