using UnityEngine;

namespace StatePattern
{
    public class IdleState : CharacterState
    {
        public override void EnterState()
        {
            Debug.Log("<color=red>Stopping</color>");
        }

        public override void UpdateState()
        {
            Debug.Log("<color=red>Stopping</color>");
        }

        public override void ExitState()
        {
            Debug.Log("<color=red>Stopping</color>");
        }
    }
}