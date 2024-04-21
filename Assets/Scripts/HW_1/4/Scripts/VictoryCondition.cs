using System;
using System.Collections.Generic;

public abstract class VictoryCondition
{
    public event Action Complete;

    protected List<Ball> _balls = new List<Ball>();

    public void Initialize(List<Ball> balls)
    {
        _balls = balls;

        foreach (var ball in balls)
        {
            ball.BallClicked += Condition;
        }
    }

    protected abstract void Condition(Ball ball);

    protected void CompleteGame()
    {
        foreach (var ball in _balls)
        {
            ball.BallClicked -= Condition;
        }

        Complete?.Invoke();
    }
}
