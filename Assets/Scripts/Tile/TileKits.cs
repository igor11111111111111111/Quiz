using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz
{
    public class TileKits : MonoBehaviour
    {
        public TileKitSO CurrentKitSO => _currentKitSO;
        private TileKitSO _currentKitSO;
        private TileKitSO[] _tileKits;

        private void Awake()
        {
            _tileKits = Resources.LoadAll<TileKitSO>("TileKits");
        }

        public void SetCurrent()
        {
            _currentKitSO = ArrayRandomizer.GetValue(_tileKits);
        }
    }
}
