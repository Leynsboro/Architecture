using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CoinSpawner
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private List<Transform> _pointsList;
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private float _timeToSpawn;

        public Action<Coin> CoinSpawned;

        private List<Transform> _usedPoints = new List<Transform>();

        private void Awake()
        {
            StartCoroutine(SpawnCoins());
        }

        public void RemoveUsedPoint(Transform point)
        {
            _usedPoints.Remove(point);
        }

        private bool IsPointUsed(Transform point)
        {
            foreach (var usedPoint in _usedPoints)
            {
                if (usedPoint == point)
                    return true;
            }

            return false;
        }

        private IEnumerator SpawnCoins()
        {
            while (true)
            {
                foreach (var point in _pointsList)
                {
                    if (IsPointUsed(point) == false)
                    {
                        var coin = Instantiate(_coinPrefab, point);
                        Coin coinIntance = coin.GetComponent<Coin>();
                        coinIntance.Init(point);

                        CoinSpawned?.Invoke(coinIntance);
                        _usedPoints.Add(point);
                    }

                }

                yield return new WaitForSeconds(_timeToSpawn);
            }
        }
    }

}
