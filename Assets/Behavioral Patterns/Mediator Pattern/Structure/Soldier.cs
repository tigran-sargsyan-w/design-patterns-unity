using UnityEngine;

namespace MediatorPattern
{
    public class Soldier : NPC
    {
        private string name;
        public Soldier(string name)
        {
            this.name = name;
        }
        
        public override void SendMessage(string message)
        {
            Debug.Log("Soldier say : " + message);
            mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Debug.Log($"{name} listen about : " + message);
        }
    }
}