using System.Linq;


public class OneColorCondition : VictoryCondition
{
    private BallColor _winColor;
    private bool _firstColorChosen = false;

    private int _count;

    protected override void Condition(Ball ball)
    {
        if (_firstColorChosen == false)
        {
            _winColor = ball.Color;
            _count = _balls.Count(balli => balli.Color == _winColor);

            _firstColorChosen = true;
        }

        if (ball.Color != _winColor)
            return; //Либо проваливаем игру

        if (--_count == 0)
        {
            CompleteGame();
        }
    }
}
