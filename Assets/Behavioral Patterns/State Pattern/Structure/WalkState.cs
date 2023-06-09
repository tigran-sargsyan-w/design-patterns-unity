using UnityEngine;

namespace StatePattern
{
    public class WalkState : CharacterState
    {
        public override void EnterState()
        {
            Debug.Log("<color=blue>Entering walk state</color>");
        }

        public override void UpdateState()
        {
            Debug.Log("<color=blue>Walking</color>");
        }

        public override void ExitState()
        {
            Debug.Log("<color=blue>Exiting walk state</color>");
        }
    }
}