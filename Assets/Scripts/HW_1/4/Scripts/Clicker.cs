using UnityEngine;

public class Clicker : MonoBehaviour
{
    private Camera _camera;

    private bool _enabled = false;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (         
            _camera is null ||
            Input.GetKey(KeyCode.Mouse0) == false ||
            Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out var hit) == false
        )
        {
            return;
        }

        if (_enabled == false)
            return;

        if (hit.transform.TryGetComponent<Ball>(out var ball))
        {
            ball.Click();
        }
        
    }

    public void Enable()
    {
        _enabled = true;
    }
}
