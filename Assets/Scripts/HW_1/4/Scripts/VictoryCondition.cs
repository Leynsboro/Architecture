using System;
using System.Collections.Generic;

public abstract class VictoryCondition
{
    public event Action Completed;
    public event Action Failed;

    protected IReadOnlyList<Ball> _balls = new List<Ball>();

    public virtual void Initialize(IReadOnlyList<Ball> balls)
    {
        _balls = balls;

        foreach (var ball in balls)
        {
            ball.BallClicked += OnClicked;
        }
    }

    protected abstract void OnClicked(Ball ball);

    protected void FailGame()
    {
        foreach (var ball in _balls)
        {
            ball.BallClicked -= OnClicked;
        }

        Failed?.Invoke();
    }

    protected void CompleteGame()
    {
        foreach (var ball in _balls)
        {
            ball.BallClicked -= OnClicked;
        }

        Completed?.Invoke();
    }
}
