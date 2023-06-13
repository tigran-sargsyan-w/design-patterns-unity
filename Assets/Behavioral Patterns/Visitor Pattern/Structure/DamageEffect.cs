using UnityEngine;

namespace VisitorPattern
{
    public class DamageEffect : EffectApplier
    {
        public override void ApplyToKnight(Knight knight)
        {
            Debug.Log("<color=red>Knight damaged.</color>");
        }

        public override void ApplyToWizard(Wizard wizard)
        {
            Debug.Log("<color=red>Wizard damaged.</color>");
        }
    }
}