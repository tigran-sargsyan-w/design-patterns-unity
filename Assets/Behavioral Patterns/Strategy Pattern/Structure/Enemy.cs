namespace StrategyPattern
{
    public class Enemy 
    {
        private IEnemyBehavior behavior;

        public void SetBehavior(IEnemyBehavior behavior)
        {
            this.behavior = behavior;
        }

        public void Move()
        {
            behavior.Move();
        }

        public void Attack()
        {
            behavior.Attack();
        }
    }
}