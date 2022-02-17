using System;

namespace Quiz
{
    public class ClickValidator
    { 
        public event Action<Tile> OnCorrectClick;
        public event Action<Tile> OnWrongClick;

        private Purpose _purpose;

        public void Init(Purpose purpose)
        {
            _purpose = purpose;
        }

        public void Process(Tile tile)
        {
            if (_purpose.Current == tile.Identifire)
            {
                OnCorrectClick?.Invoke(tile);
            }
            else
            {
                OnWrongClick?.Invoke(tile);
            }
        }
    }
}
