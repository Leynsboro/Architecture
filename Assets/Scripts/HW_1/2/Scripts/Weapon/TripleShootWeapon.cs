using System.Collections;
using UnityEngine;

public class TripleShootWeapon : Weapon
{
    private const int AMMO_PER_SHOOT = 3;
    private const float PUASE_BETWEEN_SHOTS = 0.3f;
    
    public override void Shoot()
    {
        if (_ammo > AMMO_PER_SHOOT)
        {
            _ammo -= AMMO_PER_SHOOT;
            Debug.Log("Осталось пуль " + _ammo);

            StartCoroutine(PauseBetweenShotsCoroutine());
        } else
        {
            Debug.Log("Пули кончились");
        }
    }

    private IEnumerator PauseBetweenShotsCoroutine()
    {
        for (int i = 0; i < AMMO_PER_SHOOT; i++)
        {
            CreateBullet();

            yield return new WaitForSeconds(PUASE_BETWEEN_SHOTS);
        }
    }
}
