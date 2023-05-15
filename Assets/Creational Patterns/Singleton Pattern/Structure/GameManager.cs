using UnityEngine;

namespace SingletonPattern
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        private void Start()
        {
            Debug.Log($"<color=red>{gameObject.name}-MonoBehavior-Singleton Initialized</color>");
        }
    }
}