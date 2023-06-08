using UnityEngine;

namespace BridgePattern
{
    public class Warrior : Character
    {
        public Warrior(IAbility ability) : base(ability)
        {
        }

        public override void Attack()
        {
            Debug.Log("Warrior attack");
        }

        public override void UseAbility()
        {
            ability.PerformAbility();
        }
    }
}