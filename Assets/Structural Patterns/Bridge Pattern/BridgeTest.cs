using UnityEngine;

namespace BridgePattern
{
    public class BridgeTest : MonoBehaviour
    {
        private void Start()
        {
            Character warrior = new Warrior(new MeleeAttack());
            warrior.Attack();
            //warrior.UseAbility();
            
            Character mage = new Mage(new MagicAttack());
            //mage.Attack();
            mage.UseAbility();
        }
    }
}