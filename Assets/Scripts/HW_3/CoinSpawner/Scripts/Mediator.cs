using System.Collections.Generic;
using UnityEngine;

namespace CoinSpawner
{
    public class Mediator : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;

        private List<Coin> _coins = new List<Coin>();

        //Я наделал странных вещей

        private void Awake()
        {
            _coinSpawner.CoinSpawned += OnCoinSpawn;
        }

        private void OnCoinSpawn(Coin coin)
        {
            coin.Destroyed += OnCoinDestroy;
            _coins.Add(coin);
        }

        private void OnDisable()
        {
            _coinSpawner.CoinSpawned -= OnCoinSpawn;

            foreach (Coin coin in _coins)
            {
                coin.Destroyed -= OnCoinDestroy;
            }
        }

        private void OnCoinDestroy(Coin coin, Transform point)
        {
            coin.Destroyed -= OnCoinDestroy;
            _coins.Remove(coin);

            _coinSpawner.RemoveUsedPoint(point);
        }
    }
}

