using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler
    {
        private Dictionary<KeyCode,ICommand> commands = new Dictionary<KeyCode, ICommand>();

        public void SetCommand(KeyCode keyCode, ICommand command)
        {
            if (!commands.ContainsValue(command))
            {
               commands[keyCode] = command; 
            }
        }

        public void HandleInput()
        {
            if (!Input.anyKeyDown) return;
            Debug.Log("Input detected!");
            foreach (var command in commands)
            {
                if (Input.GetKeyDown(command.Key))
                {
                    command.Value.Execute();
                }
            }
        }
    }
}