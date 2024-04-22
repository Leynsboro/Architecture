using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    public event Action<Ball> BallClicked;

    public BallColor Color;

    public void SetupBall(BallColor ballColor, Material material)
    {
        _renderer.material = material;
        Color = ballColor;
    }

    public void Click()
    {
        BallClicked?.Invoke(this);
        Destroy(gameObject);
    }
}
