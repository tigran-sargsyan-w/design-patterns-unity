using UnityEngine;

namespace StatePattern
{
    public class JumpState : CharacterState
    {
        public override void EnterState()
        {
            Debug.Log("<color=yellow>Entering jump state</color>");
        }

        public override void UpdateState()
        {
            Debug.Log("<color=yellow>Jumping</color>");
        }

        public override void ExitState()
        {
            Debug.Log("<color=yellow>Exiting jump state</color>");
        }
    }
}