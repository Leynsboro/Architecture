using UnityEngine;

public class Clicker : MonoBehaviour
{
    private Camera _camera;

    private bool _enabled = false;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetKey(KeyCode.Mouse0) && Physics.Raycast(ray, out hit, 100))
        {
            if (_enabled == false)
                return;

            if (hit.transform.TryGetComponent<Ball>(out var ball))
            {
                ball.Click();
            }
        }
    }

    public void Enable()
    {
        _enabled = true;
    }

    public void Disable()
    {
        _enabled = false;
    }
}
