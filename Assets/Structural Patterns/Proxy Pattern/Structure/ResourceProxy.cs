using UnityEngine;

namespace ProxyPattern
{
    public class ResourceProxy : IResource
    {
        private Resource resource;
        
        public ResourceProxy(Resource resource = null)
        {
            if (resource != null)
            {
               this.resource = resource; 
            }
        }
        
        public void Operation()
        {
            if (resource != null)
            {
                resource.Operation();
            }
            else
            {
                Debug.Log("<color=red>Operation from Proxy</color>");
            }
        }
    }
}