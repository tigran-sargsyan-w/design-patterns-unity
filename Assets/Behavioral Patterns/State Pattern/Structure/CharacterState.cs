namespace StatePattern
{
    public abstract class CharacterState
    {
        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void ExitState();
    }
}