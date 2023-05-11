namespace AbstractFactoryPattern
{
    public interface IEnemy 
    {
        string EnemyName { get; set; }
        void Init();
    }
}