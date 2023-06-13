namespace MementoPattern
{
    public class GameState
    {
        public int Score { get; set; }
        public int Level { get; set; }

        public GameState(int score, int level)
        {
            Score = score;
            Level = level;
        }
    }
}