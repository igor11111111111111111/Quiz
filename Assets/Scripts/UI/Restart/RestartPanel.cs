using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Quiz
{
    public class RestartPanel : MonoBehaviour
    {
        [SerializeField]
        private Button _restartButton;
        public Button RestartButton => _restartButton;
        [SerializeField]
        private GameObject _body;

        private void Awake()
        {
            Close();
        }

        public void Show()
        {
            _body.SetActive(true);
        }

        public void Close()
        {
            _body.SetActive(false);
        }
    }
}
