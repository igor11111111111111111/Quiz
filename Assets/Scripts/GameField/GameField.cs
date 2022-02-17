using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Quiz
{
    [RequireComponent(typeof(GridLayoutGroup))]
    [RequireComponent(typeof(RectTransform))]

    public class GameField : MonoBehaviour
    {
        private GridLayoutGroup _gridLayoutGroup;
        private RectTransform _rectTransform;

        public void SetSize(Vector2 fieldSize)
        {
            Vector2 cellSize = _gridLayoutGroup.cellSize;
            _rectTransform.sizeDelta = new Vector2(cellSize.x * fieldSize.x, cellSize.y * fieldSize.y);
        }

        private void Awake()
        {
            _gridLayoutGroup = GetComponent<GridLayoutGroup>();
            _rectTransform = GetComponent<RectTransform>();
        }
    }
}
