namespace MediatorPattern
{
    public abstract class Mediator 
    {
        public abstract void SendMessage(string message, NPC npc);
    }
}