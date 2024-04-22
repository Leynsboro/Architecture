using System.Collections.Generic;

public class AllColorCondition : VictoryCondition
{
    private int _count;

    public override void Initialize(IReadOnlyList<Ball> balls)
    {
        base.Initialize(balls);

        _count = balls.Count;
    }

    protected override void OnClicked(Ball ball)
    {
        _count--;

        if (_count-- == 0 )
        {
            CompleteGame();
        }
    }
}
