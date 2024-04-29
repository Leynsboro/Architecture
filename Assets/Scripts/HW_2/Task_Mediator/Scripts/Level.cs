using System;
using UnityEngine;

namespace Mediator
{
    public class Level
    {
        public event Action Defeat;

        public bool IsDefeated { get; private set; }

        private Player _player;

        public Level(Player player)
        {
            _player = player;
        }

        public void Start()
        {
            _player.Init(new Health(30), new CharacterLevel(1));
            Debug.Log("StartLevel");

            _player.Died += OnDefeat;

            IsDefeated = false;
        }

        public void Restart()
        {
            _player.Died -= OnDefeat;

            Start();
        }

        private void OnDefeat()
        {
            IsDefeated = true;

            Defeat?.Invoke();
        }
    }

}
