using UnityEngine;

namespace TemplateMethodPattern
{
    public class TutorialLevel : GameLevel
    {
        protected override void LoadLevel()
        {
            Debug.Log("<color=red>Tutorial level loaded</color>");
        }
        protected override void SetupLevel()
        {
            Debug.Log("<color=red>Tutorial level setup</color>");
        }
        protected override void StartLevel()
        {
            Debug.Log("<color=red>Starting tutorial level</color>");
        }
    }
}