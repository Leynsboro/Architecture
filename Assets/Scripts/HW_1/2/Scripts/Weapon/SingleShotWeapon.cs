using UnityEngine;

public class SingleShotWeapon : Weapon
{
    public override void Shoot()
    {
        if (_ammo > 0)
        {
            _ammo--;
            Debug.Log("Осталось пуль " + _ammo);

            CreateBullet();
        } else
        {
            Debug.Log("Пули кончились");
        }
    }
}
