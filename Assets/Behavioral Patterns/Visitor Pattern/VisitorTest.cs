using UnityEngine;

namespace VisitorPattern
{
    public class VisitorTest : MonoBehaviour
    {
        private void Start()
        {
            var knight = new Knight();
            var wizard = new Wizard();

            var damageEffect = new DamageEffect();
            var healEffect = new HealEffect();

            wizard.ApplyEffect(damageEffect);
            knight.ApplyEffect(damageEffect);
            wizard.ApplyEffect(healEffect);
            
        }
    }
}