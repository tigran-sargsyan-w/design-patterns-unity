using UnityEngine;

namespace DecoratorPattern
{
    public class DecoratorTest : MonoBehaviour
    {
        private void Start()
        {
            Bomb holyBomb = new HolyBomb();
            holyBomb.Attack();
            
            Bomb evilBomb = new EvilBomb();
            evilBomb.Attack();

            IceBombDecorator iceBomb = new IceBombDecorator();
            iceBomb.SetBombType(holyBomb);
            iceBomb.Attack();
            
            FireBombDecorator fireBomb = new FireBombDecorator();
            fireBomb.SetBombType(evilBomb);
            fireBomb.Attack();
        }
    }
}