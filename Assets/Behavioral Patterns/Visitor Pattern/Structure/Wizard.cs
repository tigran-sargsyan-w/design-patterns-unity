namespace VisitorPattern
{
    public class Wizard : Character
    {
        public override void ApplyEffect(EffectApplier effectApplier)
        {
            effectApplier.ApplyToWizard(this);
        }
    }
}