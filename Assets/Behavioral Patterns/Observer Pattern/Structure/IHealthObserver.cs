﻿namespace ObserverPattern
{
    public interface IHealthObserver
    {
        void OnHealthChanged(int health);
    }
}