using UnityEngine;

namespace ProxyPattern
{
    public class ProxyTest : MonoBehaviour
    {
        private void Start()
        {
            IResource resourceProxy = new ResourceProxy();
            resourceProxy.Operation();
            
            IResource resourceProxy2 = new ResourceProxy(new Resource());
            resourceProxy2.Operation();
            
        }
    }
}