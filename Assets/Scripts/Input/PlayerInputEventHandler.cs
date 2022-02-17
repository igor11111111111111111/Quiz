namespace Quiz
{
    public class PlayerInputEventHandler
    {
        public void Init(PlayerInput playerInput, ClickValidator clickValidator)
        {
            playerInput.OnTileClicked += clickValidator.Process;
        }
    }
}
