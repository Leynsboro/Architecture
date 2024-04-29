using System;

namespace Mediator
{
    public class PlayerMediator : IDisposable
    {
        private PlayerPanel _playerPanel;
        private Player _player;

        public PlayerMediator(PlayerPanel playerPanel, Player player)
        {
            _playerPanel = playerPanel;
            _player = player;

            _player.UpdatePanel += OnUpdatePanel;
        }

        public void Dispose()
        {
            _player.UpdatePanel -= OnUpdatePanel;
        }

        private void OnUpdatePanel(int health, int level) => _playerPanel.SetupNewValues(health, level);
    }
}

