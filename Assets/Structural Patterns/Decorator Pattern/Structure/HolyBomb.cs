using UnityEngine;

namespace DecoratorPattern
{
    public class HolyBomb : Bomb
    {
        public override void Attack()
        {
            Debug.Log("Attack with Holy Bomb");
        }
    }
}