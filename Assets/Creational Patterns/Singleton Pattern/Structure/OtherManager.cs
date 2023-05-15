using Unity.VisualScripting;
using UnityEngine;

namespace SingletonPattern
{
    public class OtherManager 
    {
        private static OtherManager instance;
        public static OtherManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OtherManager();
                }
                return instance;
            }
        }

        static OtherManager()
        {
            Debug.Log($"<color=yellow>{nameof(OtherManager)}-Non-MonoBehavior-Singleton Initialized</color>");
        }

    }
}