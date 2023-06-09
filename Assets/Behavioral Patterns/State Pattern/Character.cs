using UnityEngine;

namespace StatePattern
{
    public class Character : MonoBehaviour
    {
        private CharacterState currentState;
        private bool shiftPressed;
        
        private readonly JumpState jumpState = new JumpState();
        private readonly RunState runState = new RunState();
        private readonly WalkState walkState = new WalkState();
        private readonly IdleState idleState = new IdleState();

        public void Update()
        {
            CheckShift();
            CheckOnMovement();
        }

        private void CheckShift()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
                shiftPressed = true;
            else if (Input.GetKeyUp(KeyCode.LeftShift)) 
                shiftPressed = false;
        }

        private void CheckOnMovement()
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.W))
                    ChangeState(jumpState);
                else if (Input.GetKeyDown(KeyCode.A))
                    ChangeState(shiftPressed ? runState : walkState);
                else if (Input.GetKeyDown(KeyCode.D))
                    ChangeState(shiftPressed ? runState : walkState);
                else if (Input.GetKeyDown(KeyCode.S)) 
                    ChangeState(idleState);
            }
        }

        private void ChangeState(CharacterState newState)
        {
            //if (currentState != null) currentState.ExitState();
            currentState?.ExitState();
            currentState = newState;
            currentState.EnterState();
        }
    }
}