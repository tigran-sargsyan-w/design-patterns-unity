using UnityEngine;

namespace DecoratorPattern
{
    public class EvilBomb : Bomb
    {
        public override void Attack()
        {
            Debug.Log("Attack with Evil Bomb");
        }
    }
}