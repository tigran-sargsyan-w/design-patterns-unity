using UnityEngine;

namespace SingletonPattern
{
    public class SingletonTest : MonoBehaviour
    {
        private void Start()
        {
           var test = OtherManager.Instance;
           var test2 = OtherManager.Instance;
           
           if (test == test2)
           {
               Debug.Log("Objects are the same instance");
           }
        }
    }
}