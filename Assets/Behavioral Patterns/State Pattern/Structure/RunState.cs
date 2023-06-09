using UnityEngine;

namespace StatePattern
{
    public class RunState : CharacterState
    {
        public override void EnterState()
        {
            Debug.Log("<color=green>Entering run state</color>");
        }

        public override void UpdateState()
        {
            Debug.Log("<color=green>Running</color>");
        }

        public override void ExitState()
        {
            Debug.Log("<color=green>Exiting run state</color>");
        }
    }
}