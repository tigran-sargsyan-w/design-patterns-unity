namespace VisitorPattern
{
    public class Knight : Character
    {
        public override void ApplyEffect(EffectApplier effectApplier)
        {
            effectApplier.ApplyToKnight(this);
        }
    }
}