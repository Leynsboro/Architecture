using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private const int BULLET_TIME_DESTROYER = 3;

    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }

    public void Launch()
    {
        Destroy(gameObject, BULLET_TIME_DESTROYER);
    }
}
