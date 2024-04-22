using System.Linq;


public class OneColorCondition : VictoryCondition
{
    private BallColor _winColor;
    private bool _firstColorChosen = false;

    private int _count;

    protected override void OnClicked(Ball ball)
    {
        if (_firstColorChosen == false)
        {
            _winColor = ball.Color;
            _count = _balls.Count(balli => balli.Color == _winColor);

            _firstColorChosen = true;
        }

        if (ball.Color != _winColor)
        {
            FailGame();

            return;
        }
            

        if (--_count == 0)
        {
            CompleteGame();
        }
    }
}
