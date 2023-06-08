namespace BridgePattern
{
    public abstract class Character 
    {
        protected IAbility ability;

        public Character(IAbility ability)
        {
            this.ability = ability;
        }

        public abstract void Attack();
        public abstract void UseAbility();
    }
}