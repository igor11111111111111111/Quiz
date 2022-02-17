using UnityEngine;

namespace Quiz
{
    public class StarParticleSystem : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _particleSystem;
        private Vector3 _offset;

        private void Awake()
        {
            _offset = new Vector3(0, 0, -10);
        }

        public void Activate(Transform transform)
        {
            _particleSystem.transform.position = transform.position + _offset;
            _particleSystem.Play();
        }
    }
}
