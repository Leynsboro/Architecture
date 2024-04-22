using System.Collections;
using UnityEngine;

public class TripleShootWeapon : Weapon, IReloadable
{
    private const int AmmoPerShoot = 3;
    private const float PauseBetweenShots = 0.3f;

    public void Reload() => ReloadWeapon();

    public override void Shoot()
    {
        if (IsCanShoot())
            StartCoroutine(PauseBetweenShotsCoroutine());
        else
            Reload();
    }

    private IEnumerator PauseBetweenShotsCoroutine()
    {
        for (int i = 0; i < AmmoPerShoot; i++)
        {
            CreateBullet();

            yield return new WaitForSeconds(PauseBetweenShots);
        }
    }
}
