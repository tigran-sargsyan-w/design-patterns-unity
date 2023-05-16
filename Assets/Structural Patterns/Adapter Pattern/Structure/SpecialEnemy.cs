using UnityEngine;

namespace AdapterPattern
{
    public class SpecialEnemy : IEnemy
    {
        public void Attack()
        {
            Debug.Log("<color=yellow>Special Enemy Attack </color>");
        }
        public void Defend()
        {
            Debug.Log("<color=yellow>Special Enemy Defend </color>");
        }
    }
}