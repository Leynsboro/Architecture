using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private int _ballCount;

    [SerializeField] private Ball _ballPrefab;

    [SerializeField] private Material _redColorMat;
    [SerializeField] private Material _whiteColorMat;
    [SerializeField] private Material _greenColorMat;

    public event Action BallsSpawned;

    private const float TimeBetweenSpawn = 0.5f;

    private List<Ball> _balls = new List<Ball>();

    public void SpawnBalls()
    {
        StartCoroutine(SetupBallColor());
    }

    public IReadOnlyList<Ball> GetBalls()
    {
        return _balls;
    }

    private IEnumerator SetupBallColor()
    {
        for (int i = 0; i < _ballCount; i++)
        {
            var ball = Instantiate(_ballPrefab, transform);

            var random = UnityEngine.Random.Range(0, 3);

            switch (random)
            {
                case 0:
                    _ballPrefab.SetupBall(BallColor.red, _redColorMat);
                    break;
                case 1:
                    _ballPrefab.SetupBall(BallColor.white, _whiteColorMat);
                    break;
                case 2:
                    _ballPrefab.SetupBall(BallColor.green, _greenColorMat);
                    break;
            }

            _balls.Add(ball);
                        
            yield return new WaitForSeconds(TimeBetweenSpawn);   
        }

        BallsSpawned?.Invoke();
    }
}
