using UnityEngine;

namespace BridgePattern
{
    public class Mage : Character
    {
        public Mage(IAbility ability) : base(ability)
        {
        }

        public override void Attack()
        {
            Debug.Log("Mage attack");
        }

        public override void UseAbility()
        {
            ability.PerformAbility();
        }
    }
}