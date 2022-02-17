using UnityEngine;

namespace Quiz
{
    public class LevelInitEventHandler
    {
        public void Init(Level level, GameField gameField, TileSpawner tileSpawner, Purpose purpose, DatasContainer datasContainer, PurposePanel purposePanel, CanvasGroup canvasGroup, PlayerInput playerInput, TileKits tileKits)
        {
            OnFirstLevelStartedHandler(level, purposePanel, tileSpawner);
            OnLevelChangedHandler(level, tileSpawner, gameField, datasContainer, purpose, purposePanel, tileKits);
            OnLastLevelDoneHandler(level, canvasGroup, playerInput);
        }
         
        public void OnFirstLevelStartedHandler(Level level, PurposePanel purposePanel, TileSpawner tileSpawner)
        {
            level.OnFirstLevelStarted += () =>
            {
                BounceEffect BounceEffect = new BounceEffect();
                foreach (Tile tile in tileSpawner.Tiles)
                {
                    BounceEffect.Activate(tile.transform);
                }

                purposePanel.SetZeroAlpha();

                FadeEffect fadeEffect = new FadeEffect();
                fadeEffect.FadeIn(purposePanel.CanvasGroup, 3);
            };
        }

        public void OnLevelChangedHandler(Level level, TileSpawner tileSpawner, GameField gameField, DatasContainer datasContainer, Purpose purpose, PurposePanel purposePanel, TileKits tileKits)
        {
            level.OnLevelChanged += () =>
            {
                gameField.SetSize(level.CurrentLevelSO.Size);

                tileKits.SetCurrent();

                datasContainer.SetAllDatas(tileKits.CurrentKitSO.TileDatas);

                tileSpawner.Clear();
                tileSpawner.Spawn(level.CurrentLevelSO.CountTiles);

                TileData tileData = datasContainer.GetRandomPurposeData();
                purpose.Current = tileData.Identifier;

                purposePanel.Refresh(purpose.Current);
            };
        }

        public void OnLastLevelDoneHandler(Level level, CanvasGroup canvasGroup, PlayerInput playerInput)
        {
            level.OnLastLevelDone += () =>
            {
                FadeEffect fadeEffect = new FadeEffect();
                fadeEffect.FadeIn(canvasGroup, 3);
                playerInput.IsCanUse = false;
            };
        }
    }
} 
