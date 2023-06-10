using UnityEngine;

namespace MediatorPattern
{
    public class MediatorTest : MonoBehaviour
    {
        private NPCMediator mediator;

        private void Start()
        {
            mediator = new NPCMediator();
            NPC villager1 = new Villager("Villager 1");
            NPC villager2 = new Villager("Villager 2");
            NPC soldier1 = new Soldier("Soldier 1");
            NPC soldier2 = new Soldier("Soldier 2");

            mediator.AddNPC(villager1);
            mediator.AddNPC(villager2);
            mediator.AddNPC(soldier1);
            mediator.AddNPC(soldier2);

            villager1.SetMediator(mediator);
            villager2.SetMediator(mediator);
            soldier1.SetMediator(mediator);
            soldier2.SetMediator(mediator);

            villager1.SendMessage("Hi there.I'm villager 1");
            //villager2.SendMessage("Hi there.I'm villager 2");
            //soldier1.SendMessage("Hi there.I'm soldier 1");
            //soldier2.SendMessage("Hi there.I'm soldier 2");
        }
    }
}