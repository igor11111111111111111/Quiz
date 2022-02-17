using UnityEngine;

namespace Quiz
{
    public class ClickValidatorEventHadler
    {
        public void Init(ClickValidator clickValidator, Level level, StarParticleSystem starParticleSystem)
        {
            clickValidator.OnCorrectClick += (tile) =>
            {
                Transform image = tile.GetImageTransform();
                starParticleSystem.Activate(image);
                level.SetNext();
            };

            clickValidator.OnWrongClick += (tile) =>
            {
                ShakeEffect shakeEffect = new ShakeEffect();
                shakeEffect.Activate(tile.GetImageTransform());
            };
        }
    }
}
