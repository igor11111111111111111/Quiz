using UnityEngine;
using UnityEngine.UI;

namespace Quiz
{
    public class Tile : MonoBehaviour
    {
        [SerializeField]
        private Image _image;
        [SerializeField]
        private RectTransform _imageTransform;

        public string Identifire => _identifire;
        private string _identifire;

        public void Init(TileData data)
        {
            _identifire = data.Identifier;
            _image.sprite = data.Sprite;
            _imageTransform.Rotate(0, 0, data.RotateAngle);
        }

        public Transform GetImageTransform()
        {
            return _image.transform;
        }
    }
}
