using System;
using UnityEngine;
using Zenject;

namespace HW4.Mediator
{
    public class GameplayMediator : IDisposable
    {
        private DefeatPanel _defeatPanel;
        private Level _level;

        [Inject]
        public void Construct(Level level, DefeatPanel defeatPanel)
        {
            _level = level;
            _level.Defeat += OnLevelDefeat;
            _defeatPanel = defeatPanel;
        }

        public void Dispose()
        {
            _level.Defeat -= OnLevelDefeat;
        }

        private void OnLevelDefeat()
        {
            _defeatPanel.Show();
        }

        public void RestartLevel()
        {
            _defeatPanel.Hide();
            _level.Restart();
        }
    }
}

