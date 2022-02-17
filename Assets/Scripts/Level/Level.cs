using System;
using UnityEngine;
using System.Linq;

namespace Quiz
{
    public class Level : MonoBehaviour
    { 
        public event Action OnLevelChanged;
        public event Action OnFirstLevelStarted;
        public event Action OnLastLevelDone;

        private LevelSO[] _levels;
        private TileKits _tileKits;

        public LevelSO CurrentLevelSO => _currentLevelSO;
        private LevelSO _currentLevelSO;

        private void Awake()
        {
            _levels = Resources.LoadAll<LevelSO>("Levels");
        }

        public void Init(TileKits tileKits)
        {
            _tileKits = tileKits;
        }

        public void SetFirst()
        {
            _currentLevelSO = _levels[0];
            OnLevelChanged?.Invoke();
            OnFirstLevelStarted?.Invoke();
        }

        public void SetNext()
        {
           
            int index = Array.IndexOf(_levels, _currentLevelSO) + 1;

            try
            {
                _levels.Contains(_levels[index]);
            }
            catch (IndexOutOfRangeException)
            {
                OnLastLevelDone?.Invoke();
                return;
            }

            _currentLevelSO = _levels[index];

            OnLevelChanged?.Invoke();
        }
    }
}
