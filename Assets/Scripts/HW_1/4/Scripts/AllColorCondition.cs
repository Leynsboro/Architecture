public class AllColorCondition : VictoryCondition
{
    protected override void Condition(Ball ball)
    {
        _balls.Remove(ball);

        if (_balls.Count == 0 )
        {
            CompleteGame();
        }
    }
}
