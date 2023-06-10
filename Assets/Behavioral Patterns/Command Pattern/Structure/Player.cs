using UnityEngine;

namespace CommandPattern
{
    public class Player
    {
        public void Attack()
        {
            Debug.Log("<color=red>Player attacks!</color>");
        }

        public void Jump()
        {
            Debug.Log("<color=yellow>Player jumps!</color>");
        }
    }
}