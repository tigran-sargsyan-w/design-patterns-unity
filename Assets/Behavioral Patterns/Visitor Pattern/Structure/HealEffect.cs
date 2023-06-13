using UnityEngine;

namespace VisitorPattern
{
    public class HealEffect : EffectApplier
    {
        public override void ApplyToKnight(Knight knight)
        {
            Debug.Log("<color=yellow>Knight healed.</color>");
        }

        public override void ApplyToWizard(Wizard wizard)
        {
            Debug.Log("<color=yellow>Wizard healed.</color>");
        }
    }
}