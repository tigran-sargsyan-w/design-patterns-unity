using UnityEngine;

namespace TemplateMethodPattern
{
    public abstract class GameLevel 
    {
        public void PlayLevel()
        {
            LoadLevel();
            SetupLevel();
            StartLevel();
            //Other level logic
            EndLevel();
        }

        protected abstract void LoadLevel();
        protected abstract void SetupLevel();
        protected abstract void StartLevel();
        protected virtual void EndLevel()
        {
            //Common end level logic
            Debug.Log("Level ended");
        }
    }
}