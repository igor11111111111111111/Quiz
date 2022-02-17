namespace Quiz
{
    public class LevelRestartPanelHadler
    {
        public void Init(Level level, RestartPanel restartPanel)
        {
            level.OnLastLevelDone += () =>
            {
                restartPanel.Show();
            };
        } 
    }
} 
