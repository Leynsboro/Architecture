using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private const int BulletTimeDestroyer = 3;

    private bool _isLaunched = false;

    private void Update()
    {
        if (_isLaunched)
            transform.Translate(transform.forward * _speed * Time.deltaTime);
    }

    public void Launch()
    {
        _isLaunched = true;
        Destroy(gameObject, BulletTimeDestroyer);
    }
}
