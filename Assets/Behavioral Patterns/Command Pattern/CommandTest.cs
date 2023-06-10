using UnityEngine;

namespace CommandPattern
{
    public class CommandTest : MonoBehaviour
    {
        private InputHandler inputHandler;
        private void Start()
        {
            Player player = new Player();
            ICommand attackCommand = new AttackCommand(player);
            ICommand jumpCommand = new JumpCommand(player);

            inputHandler = new InputHandler();
            inputHandler.SetCommand(KeyCode.W, jumpCommand);
            inputHandler.SetCommand(KeyCode.Space, attackCommand);
        }

        private void Update()
        {
            inputHandler.HandleInput();
        }
    }
}