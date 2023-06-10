using UnityEngine;

namespace MediatorPattern
{
    public class Villager : NPC
    {
        private string name;
        public Villager(string name)
        {
            this.name = name;
        }
        
        public override void SendMessage(string message)
        {
            Debug.Log("Villager say : " + message);
            mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Debug.Log($"{name} listen about : " + message);
        }
    }
}