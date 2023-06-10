namespace MediatorPattern
{
    public abstract class NPC 
    {
        protected Mediator mediator;

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }
}