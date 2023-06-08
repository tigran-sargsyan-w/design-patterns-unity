using UnityEngine;

namespace BridgePattern
{
    public class MeleeAttack : IAbility
    {
        public void PerformAbility()
        {
            Debug.Log("Ability: Attack with melee weapon");
        }
    }
}