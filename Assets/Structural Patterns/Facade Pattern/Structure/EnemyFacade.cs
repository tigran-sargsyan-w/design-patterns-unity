namespace FacadePattern
{
    public class EnemyFacade
    {
        private Enemy enemy;
        public EnemyFacade()
        {
            enemy = new Enemy();
        }
        public void TryAttack()
        {
            enemy.LookingForPlayer();
            enemy.MoveToPlayer();
            enemy.Hit();
        }
        public void TryDefend()
        {
            enemy.TryToDodge();
            enemy.TryToDefend();
            enemy.GetDamage();
        }
    }
}