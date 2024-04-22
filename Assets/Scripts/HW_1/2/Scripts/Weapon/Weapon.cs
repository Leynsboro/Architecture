using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _bulletPoint;

    //public abstract string WeaponName;
    //Хотел прикрутить название имени для оружия, чтобы при смене в WeaponSwitcher выводил в консоль
    //Не понял как грамотно сделать. Хотелось бы понять)))

    private int _ammoInMag;
    protected int _ammo { get; private set; }

    public void Initialize(int ammo)
    {
        _ammo = ammo;
        _ammoInMag = ammo;
    }

    public abstract void Shoot();

    protected bool IsCanShoot()
    {
        if (_ammo > 0)
        {
            return true;
        } else
        {
            Debug.Log("Закончились патроны");
            return false;
        }

    }

    protected void CreateBullet()
    {
        _ammo--;

        Debug.Log("Осталось пуль " + _ammo);

        var bullet = Instantiate(_bullet);
        bullet.transform.forward = _bullet.transform.forward;
        bullet.transform.position = _bulletPoint.transform.position;

        bullet.Launch();
    }

    protected void ReloadWeapon()
    {
        Debug.Log("Перезарядка");
        _ammo = _ammoInMag;
    }

}
