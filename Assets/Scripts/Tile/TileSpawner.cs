
using System.Collections.Generic;
using UnityEngine;

namespace Quiz
{
    public class TileSpawner : MonoBehaviour
    {
        [SerializeField] Tile _tilePrefab;
        [SerializeField] Transform _parent;
        private DatasContainer _datasContainer;
        public Tile[] Tiles => _tiles;
        private Tile[] _tiles;

        public void Init(DatasContainer datasContainer)
        {
            _datasContainer = datasContainer;
        }

        public void Spawn(int count)
        {
            _tiles = new Tile[count];

            for (int i = 0; i < count; i++)
            {
                _tiles[i] = Spawn();
            }
        }

        private Tile Spawn()
        {
            Tile tile = Instantiate(_tilePrefab, _parent);
            TileData data = _datasContainer.GetRandomTileData();
            tile.Init(data);

            return tile;
        }

        public void Clear()
        {
            foreach (Transform child in _parent)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
