using System;
using UnityEngine;

namespace Mediator
{
    public class Player : MonoBehaviour
    {
        public event Action Died;
        public event Action<int, int> UpdatePanel;

        private Health _health;
        private CharacterLevel _characterLevel;

        public void Init(Health health, CharacterLevel characterLevel)
        {
            _health = health;
            _characterLevel = characterLevel;

            _health.Died += OnPlayerDeath;

            UpdatePanel?.Invoke(_health.Value, _characterLevel.Value);
        }

        public void TakeDamage(int value)
        {
            _health.Reduce(value);

            UpdatePanel?.Invoke(_health.Value, _characterLevel.Value);
        }

        public void LevelUp()
        {
            _characterLevel.IncreaseLevel();
            _health.IncreaseMaxHealth();

            UpdatePanel?.Invoke(_health.Value, _characterLevel.Value);
        }

        private void OnPlayerDeath()
        {
            Died?.Invoke();

            _health.Died -= OnPlayerDeath;
        } 
    }

}
