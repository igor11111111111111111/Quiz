
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    public class DatasContainer
    {
        private TileData[] _allDatas;
        private List<TileData> _usedDatas;
        private List<TileData> _usedPurposeDatas;

        public void SetAllDatas(TileData[] allDatas)
        {
            _allDatas = allDatas;
            SetupDatas();
        }

        public TileData GetRandomTileData()
        {
            return GetRandomData(_allDatas, _usedDatas);
        }

        public TileData GetRandomPurposeData()
        {
            return GetRandomData(_usedDatas, _usedPurposeDatas);
        }

        private TileData GetRandomData(IEnumerable<TileData> reduced, IEnumerable<TileData> subtracted)
        {
            TileData[] freeDatas = reduced.Except(subtracted).ToArray();
            TileData tile = ArrayRandomizer.GetValue(freeDatas);
            _usedDatas.Add(tile);

            return tile;
        }

        private void SetupDatas()
        {
            ClearData(ref _usedDatas);
            ClearData(ref _usedPurposeDatas);
        }

        private void ClearData(ref List<TileData> data)
        {
            if (data != null)
            {
                data.Clear();
            }
            else
            {
                data = new List<TileData>();
            }
        }
    }
}
