using UnityEngine;

namespace BridgePattern
{
    public class MagicAttack : IAbility
    {
        public void PerformAbility()
        {
            Debug.Log("Ability: Attack with magic");
        }
    }
}