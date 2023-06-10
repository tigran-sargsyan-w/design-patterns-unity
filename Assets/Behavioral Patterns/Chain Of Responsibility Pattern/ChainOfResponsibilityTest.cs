using UnityEngine;

namespace ChainOfResponsibilityPattern
{
    public class ChainOfResponsibilityTest : MonoBehaviour
    {
        private AccessHandler accessHandler;
        private void Start()
        {
            CreateHandlerChain();
            
            MakeDecision();
        }

        private void CreateHandlerChain()
        {
            accessHandler = new ItemCheckHandler();
            AccessHandler taskHandler = new TaskCompletionHandler();
            AccessHandler levelHandler = new LevelRequirementHandler();

            accessHandler.SetNextHandler(taskHandler);
            taskHandler.SetNextHandler(levelHandler);
        }

        private void MakeDecision()
        {
            if (CheckAccess())
            {
                Debug.Log("<color=green>Access granted. The player can access the secret level.</color>");
            }
            else
            {
                Debug.Log("<color=red>Access denied. The player has failed all access checks.</color>");
            }
        }

        private bool CheckAccess()
        {
            return accessHandler.ProcessRequest();
        }
    }
}