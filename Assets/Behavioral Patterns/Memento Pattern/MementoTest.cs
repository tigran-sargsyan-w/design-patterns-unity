using UnityEngine;

namespace MementoPattern
{
    public class MementoTest : MonoBehaviour
    {
        private Game game;
        private GameSaver saver;

        private void Start()
        {
            game = new Game();
            saver = new GameSaver();

            // New game state
            game.IncreaseScore(100);
            game.AdvanceLevel();
            game.PrintGameInfo();

            // save game state
            GameState initialState = game.SaveState();
            saver.GameState = initialState;

            // Change game state
            game.IncreaseScore(200);
            game.AdvanceLevel();
            game.PrintGameInfo();

            // Restore game state
            game.RestoreState(saver.GameState);
            game.PrintGameInfo();
        }
    }
}