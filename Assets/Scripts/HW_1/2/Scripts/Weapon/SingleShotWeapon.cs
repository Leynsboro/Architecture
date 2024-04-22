using UnityEngine;

public class SingleShotWeapon : Weapon, IReloadable
{
    public void Reload() => ReloadWeapon();

    public override void Shoot()
    {
        if (IsCanShoot())
            CreateBullet();
        else
            Reload();
    }

}
