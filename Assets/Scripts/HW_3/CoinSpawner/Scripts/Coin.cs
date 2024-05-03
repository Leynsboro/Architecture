using System;
using UnityEngine;

namespace CoinSpawner
{
    public class Coin : MonoBehaviour
    {
        private Transform _spawnPoint;

        public Action<Coin, Transform> Destroyed;

        public void Init(Transform point)
        {
            _spawnPoint = point;
        }

        private void OnDisable()
        {
            Destroyed?.Invoke(this, _spawnPoint);
        }
    }
}

