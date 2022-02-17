using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Quiz
{
    [CreateAssetMenu(fileName = "TileKitSO", menuName = "SO/TileKitSO", order = 1)]
    public class TileKitSO : ScriptableObject
    {
        [SerializeField]
        private TileData[] _tileDatas;
        public TileData[] TileDatas => _tileDatas;
    }
}
