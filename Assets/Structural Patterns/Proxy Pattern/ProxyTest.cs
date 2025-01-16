using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace ProxyPattern
{
    public class Instance<T> where T : new() // Singleton for service locator
    {
        public static T Value = new T();
    } 
    public class ProxyTest : MonoBehaviour
    {
        private int a;
        
        int[] array = new int[10];
        
        private void Start()
        {
            //fill array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            PrintArray(array);
            
            var sub2 = new Span<int>(array, 5, 5);
            
            sub2[0] = 100;
            PrintArray(sub2.ToArray());
            PrintArray(array);



            //var proxyTest = Instance<ProxyTest>.Value;
            /*IResource resourceProxy = new ResourceProxy();
            resourceProxy.Operation();
            
            IResource resourceProxy2 = new ResourceProxy(new Resource());
            resourceProxy2.Operation();*/
            
        }

        private void PrintArray(int[] array)
        {
            Debug.Log("Array: " + string.Join(", ", array));
        }
    }
}