namespace DecoratorPattern
{
    public class BombDecorator : Bomb
    {
        private Bomb bomb;
        
        public void SetBombType(Bomb newBomb)
        {
            bomb = newBomb;
        }
        
        public override void Attack()
        {
            if (bomb != null)
            {
                bomb.Attack();
            }
        }
    }
}