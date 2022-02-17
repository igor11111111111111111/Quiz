using UnityEngine;
using UnityEngine.UI;

namespace Quiz
{
    public class RestartButtonHandler
    {
        public void Init(Button button, PlayerInput playerInput, Level level, CanvasGroup mainCanvasGroup, RestartPanel restartPanel)
        {
            button.onClick.AddListener(() => 
            {
                playerInput.IsCanUse = true;
                FadeEffect fadeEffect = new FadeEffect();
                fadeEffect.FadeOut(mainCanvasGroup, 3);
                restartPanel.Close();
                level.SetFirst();
            } );
        }
    }
} 
