using UnityEngine;

public class SingleShotWeapon : Weapon
{
    public override void Shoot()
    {
        if (_ammo > 0)
        {
            _ammo--;
            Debug.Log("�������� ���� " + _ammo);

            CreateBullet();
        } else
        {
            Debug.Log("���� ���������");
        }
    }
}
