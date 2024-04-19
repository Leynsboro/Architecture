using UnityEngine;

public class InfiniteShootWeapon : Weapon
{
    public override void Shoot()
    {
        CreateBullet();
        Debug.Log("Пули бесконечны, кайфуем");
    }
}
