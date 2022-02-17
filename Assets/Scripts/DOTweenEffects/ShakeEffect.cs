using DG.Tweening;
using UnityEngine;

namespace Quiz
{
    public class ShakeEffect
    {
        public void Activate(Transform transform)
        {
            transform.DOShakePosition(1, 10);
        }
    }
}
