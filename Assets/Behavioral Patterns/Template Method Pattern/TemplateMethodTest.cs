using UnityEngine;

namespace TemplateMethodPattern
{
    public class TemplateMethodTest : MonoBehaviour
    {
        private void Start()
        {
            TutorialLevel tutorialLevel = new TutorialLevel();
            tutorialLevel.PlayLevel();

            ChallengeLevel challengeLevel = new ChallengeLevel();
            challengeLevel.PlayLevel();
        }
    }
}