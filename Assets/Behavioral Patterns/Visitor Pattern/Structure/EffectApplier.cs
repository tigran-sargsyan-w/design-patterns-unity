namespace VisitorPattern
{
    public abstract class EffectApplier
    {
        public abstract void ApplyToKnight(Knight knight);
        public abstract void ApplyToWizard(Wizard wizard);
    }
}