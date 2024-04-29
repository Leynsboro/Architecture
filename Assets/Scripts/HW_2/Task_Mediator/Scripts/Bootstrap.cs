using UnityEngine;

namespace Mediator
{
    public class Bootstrap : MonoBehaviour
    {
        private const int DamageValue = 6;

        [SerializeField] private Player _player;
        [SerializeField] private PlayerPanel _playerPanel;
        [SerializeField] private DefeatPanel _defeatPanel;

        private PlayerMediator _playerMediator;
        private GameplayMediator _gameplayMediator;

        private Level _level;

        private void Awake()
        {
            _level = new Level(_player);

            _playerMediator = new PlayerMediator(_playerPanel, _player);
            _gameplayMediator = new GameplayMediator(_defeatPanel, _level);

            _defeatPanel.Init(_gameplayMediator);

            _level.Start();
        }

        private void Update()
        {
            if (_level.IsDefeated == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                    _player.TakeDamage(DamageValue);

                if (Input.GetKeyDown(KeyCode.E))
                    _player.LevelUp();
            }          
        }
    }
}

