using System;
using UnityEngine;

public enum BallColor
{
    red,
    white,
    green
}

public class Ball : MonoBehaviour
{
    public event Action<Ball> BallClicked;

    public BallColor Color; //{ get; private set; }
    //Почему-то когда ставлю геттер сеттер у поля BallColor вечно рандом значение

    public void SetupBall(BallColor ballColor, Material material)
    {
        transform.GetComponent<Renderer>().material = material;
        Color = ballColor;
    }

    public void Click()
    {
        BallClicked?.Invoke(this);
        Destroy(gameObject);
    }
}
