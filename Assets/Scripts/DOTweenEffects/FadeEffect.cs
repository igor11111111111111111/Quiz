using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz
{
    public class FadeEffect
    {
        private Tween _tween;

        public void FadeOut(CanvasGroup canvasGroup, int duration)
        {
            Fade(canvasGroup, 0, duration);
        }

        public void FadeIn(CanvasGroup canvasGroup, int duration)
        {
            Fade(canvasGroup, 1, duration);
        }

        private void Fade(CanvasGroup canvasGroup, float value, float duration)
        {
            _tween?.Kill();
            _tween = canvasGroup.DOFade(value, duration);
        }
    }
}
