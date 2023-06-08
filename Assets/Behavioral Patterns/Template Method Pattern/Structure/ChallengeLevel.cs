using UnityEngine;

namespace TemplateMethodPattern
{
    public class ChallengeLevel : GameLevel
    {
        protected override void LoadLevel()
        {
            Debug.Log("<color=yellow>Challenge level loaded</color>");
        }
        protected override void SetupLevel()
        {
            Debug.Log("<color=yellow>Challenge level setup</color>");
        }
        protected override void StartLevel()
        {
            Debug.Log("<color=yellow>Starting challenge level</color>");
        }
        protected override void EndLevel()
        {
            Debug.Log("<color=yellow>Challenge level ended</color>");
            base.EndLevel();
        }
    }
}