using UnityEngine;

namespace ProxyPattern
{
    public class Resource : IResource
    {
        public void Operation()
        {
            Debug.Log("Operation from Resource");
        }
    }
}