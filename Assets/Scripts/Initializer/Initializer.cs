using UnityEngine;
using UnityEngine.UI;

namespace Quiz
{
    public class Initializer : MonoBehaviour
    {
        [SerializeField]
        private PurposePanel _purposePanel;
        [SerializeField]
        private RestartPanel _restartPanel;
        [SerializeField]
        private GameField _gameField;
        [SerializeField]
        private TileSpawner _tileSpawner;
        [SerializeField]
        private Level _level;
        [SerializeField]
        private PlayerInput _playerInput;
        [SerializeField]
        private StarParticleSystem _starParticleSystem;
        [SerializeField]
        private CanvasGroup _mainCanvasGroup;
        [SerializeField]
        private TileKits _tileKits;

        private Purpose _purpose;
        private DatasContainer _datasContainer;
        private ClickValidator _clickValidator;

        private void Start()
        {
            _purpose = new Purpose();
            _datasContainer = new DatasContainer();
            _clickValidator = new ClickValidator();
            _clickValidator.Init(_purpose);
            _tileSpawner.Init(_datasContainer);
            _level.Init(_tileKits);

            RestartHandler();

            LevelInitEventHandler();
            PlayerInputEventHandler();
            ClickValidatorEventHadler();

            _level.SetFirst();
        }

        public void LevelInitEventHandler()
        {
            LevelInitEventHandler levelHandler = new LevelInitEventHandler();

            levelHandler.Init(_level, _gameField, _tileSpawner, _purpose, _datasContainer, _purposePanel, _mainCanvasGroup, _playerInput, _tileKits);
        }

        public void PlayerInputEventHandler()
        {
            PlayerInputEventHandler playerInputHandler = new PlayerInputEventHandler();
            playerInputHandler.Init(_playerInput, _clickValidator);
        }

        public void ClickValidatorEventHadler()
        {
            ClickValidatorEventHadler _clickValidatorHadler = new ClickValidatorEventHadler();
            _clickValidatorHadler.Init(_clickValidator, _level, _starParticleSystem);
        }

        public void RestartHandler()
        {
            LevelRestartPanelHadler levelRestartPanelHadler = new LevelRestartPanelHadler();
            levelRestartPanelHadler.Init(_level, _restartPanel);

            RestartButtonHandler restartButtonHandler = new RestartButtonHandler();
            restartButtonHandler.Init(_restartPanel.RestartButton, _playerInput, _level, _mainCanvasGroup, _restartPanel);
        }


    }
}
