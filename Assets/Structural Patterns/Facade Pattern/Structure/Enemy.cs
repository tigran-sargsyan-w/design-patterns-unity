using UnityEngine;

namespace FacadePattern
{
    public class Enemy
    {
        public void LookingForPlayer()
        {
            Debug.Log("Enemy Looking For Player");
        }
        public void MoveToPlayer()
        {
            Debug.Log("Enemy Move To Player");
        }
        public void Hit()
        {
            Debug.Log("Enemy Hit");
        }
        
        public void TryToDodge()
        {
            Debug.Log("Enemy Try To Dodge");
        }
        public void TryToDefend()
        {
            Debug.Log("Enemy Try To Defend");
        }
        public void GetDamage()
        {
            Debug.Log("Enemy Get Damage");
        }
    }
}