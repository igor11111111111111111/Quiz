using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz
{
    [Serializable]
    public class TileData
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private string _identifier;
        [SerializeField]
        [Range(-180, 180)]
        private int _rotateAngle;

        public Sprite Sprite => _sprite;
        public string Identifier => _identifier;
        public int RotateAngle => _rotateAngle;
    }
}
