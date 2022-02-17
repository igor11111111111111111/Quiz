using UnityEngine;

namespace Quiz
{
    [CreateAssetMenu(fileName = "LevelSO", menuName = "SO/LevelSO", order = 2)]

    public class LevelSO : ScriptableObject
    {
        [SerializeField]
        private int _row;

        [SerializeField]
        private int _column;

        public Vector2 Size => new Vector2(_column, _row);
        public int CountTiles => _row * _column;
    }
}
