using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Bullet _bullet;
    [SerializeField] private Transform _bulletPoint;

    //public abstract string WeaponName;
    //Хотел прикрутить название имени для оружия, чтобы при смене в WeaponSwitcher выводил в консоль
    //Не понял как грамотно сделать. Хотелось бы понять)))

    protected int _ammo;

    public void Initialize(int ammo)
    {
        _ammo = ammo;
    }

    public abstract void Shoot(); // Вот этот метод вероято надо было лучше раскрыть при реализации в дочерних
    protected virtual void CreateBullet()
    {
        var bullet = Instantiate(_bullet);
        bullet.transform.forward = _bullet.transform.forward;
        bullet.transform.position = _bulletPoint.transform.position;

        bullet.Launch();
    }

}
