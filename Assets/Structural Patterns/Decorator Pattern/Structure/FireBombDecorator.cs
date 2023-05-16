using UnityEngine;

namespace DecoratorPattern
{
    public class FireBombDecorator : BombDecorator
    {
        public override void Attack()
        {
            base.Attack();
            AddFireAttack();
        }

        private void AddFireAttack()
        {
            Debug.Log("<color=red>Add Fire effect to bomb</color>");
        }
    }
}