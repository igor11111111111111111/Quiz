using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Quiz
{
    public class PurposePanel : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        public CanvasGroup CanvasGroup => _canvasGroup;
        private CanvasGroup _canvasGroup;

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public void Refresh(string text)
        {
            _text.text = "Find " + text;
        }

        public void SetZeroAlpha()
        {
            _canvasGroup.alpha = 0;
        }
    }
}
