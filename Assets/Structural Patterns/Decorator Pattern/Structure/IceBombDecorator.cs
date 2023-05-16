using UnityEngine;

namespace DecoratorPattern
{
    public class IceBombDecorator : BombDecorator
    {
        public override void Attack()
        {
            base.Attack();
            AddIceAttack();
        }

        private void AddIceAttack()
        {
            Debug.Log("<color=blue>Add Ice effect to bomb</color>");
        }
    }
}