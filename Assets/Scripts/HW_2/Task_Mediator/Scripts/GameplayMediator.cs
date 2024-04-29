using System;

namespace Mediator
{
    public class GameplayMediator: IDisposable
    {
        private DefeatPanel _defeatPanel;
        private Level _level;

        public GameplayMediator(DefeatPanel defeatPanel, Level level)
        {
            _defeatPanel = defeatPanel;
            _level = level;

            _level.Defeat += OnLevelDefeat;
        }

        public void Dispose()
        {
            _level.Defeat -= OnLevelDefeat;
        }

        private void OnLevelDefeat() => _defeatPanel.Show();

        public void RestartLevel()
        {
            _defeatPanel.Hide();
            _level.Restart();
        } 
    }

}
