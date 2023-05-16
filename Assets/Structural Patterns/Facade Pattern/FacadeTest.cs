using UnityEngine;

namespace FacadePattern
{
    public class FacadeTest : MonoBehaviour
    {
        [SerializeField] private EnemyState enemyState;
        
        private EnemyFacade enemyFacade;
        
        void Start()
        {
            enemyFacade = new EnemyFacade();
            CheckEnemyState();
        }

        private void CheckEnemyState()
        {
            switch (enemyState)
            {
                case EnemyState.Attack:
                    enemyFacade.TryAttack();
                    break;
                case EnemyState.Defend:
                    enemyFacade.TryDefend();
                    break;
            }
        }
    }
}