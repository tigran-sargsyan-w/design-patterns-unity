using UnityEngine;

namespace MementoPattern
{
    public class Game
    {
        private int score;
        private int level;

        public GameState SaveState()
        {
            return new GameState(score, level);
        }

        public void RestoreState(GameState state)
        {
            score = state.Score;
            level = state.Level;
        }

        public void IncreaseScore(int points)
        {
            score += points;
        }

        public void AdvanceLevel()
        {
            level++;
        }

        public void PrintGameInfo()
        {
            Debug.Log($"Score: {score}, Level: {level}");
        }
    }
}