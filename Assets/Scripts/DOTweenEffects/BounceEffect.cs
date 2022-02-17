using DG.Tweening;
using UnityEngine;

namespace Quiz
{
    public class BounceEffect
    {
        public void Activate(Transform transform)
        {
            transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 1, 5, 1.5f);
        }
    }
}
