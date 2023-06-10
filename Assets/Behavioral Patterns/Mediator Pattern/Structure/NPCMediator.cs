using System.Collections.Generic;

namespace MediatorPattern
{
    public class NPCMediator : Mediator
    {
        private List<NPC> npcs = new List<NPC>();

        public override void SendMessage(string message, NPC npc)
        {
            foreach (var otherNPC in npcs)
            {
                if (otherNPC != npc)
                {
                    otherNPC.ReceiveMessage(message);
                }
            }
        }

        public void AddNPC(NPC npc)
        {
            npcs.Add(npc);
        }
    }
}