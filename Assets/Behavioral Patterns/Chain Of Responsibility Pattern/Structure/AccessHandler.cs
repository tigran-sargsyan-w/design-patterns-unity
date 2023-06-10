using UnityEngine;

namespace ChainOfResponsibilityPattern
{
    public abstract class AccessHandler 
    {
        private AccessHandler nextHandler;

        public void SetNextHandler(AccessHandler handler)
        {
            nextHandler = handler;
        }

        protected abstract bool CheckAccess();

        public bool ProcessRequest()
        {
            if (CheckAccess())
            {
                Debug.Log($"{this.GetType().Name} successfully passed the access check.");
                if (nextHandler != null)
                {
                    return nextHandler.ProcessRequest();
                }
                else
                {
                    Debug.Log("Access granted.");
                    return true;
                }
            }
            else
            {
                Debug.Log($"{this.GetType().Name} access check failed.");
                return false;
            }
        }
    }
}