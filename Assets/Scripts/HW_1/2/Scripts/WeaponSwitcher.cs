using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private Weapon[] _weapons;
    [SerializeField] private Shooter _shooter;

    private void Awake()
    {
        foreach (var weapon in _weapons)
        {
            if (weapon is InfiniteShootWeapon == false)
            {
                weapon.Initialize(30);
            }
        }

        SwitchWeapon(_weapons[0]);
    }

    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            SwitchWeapon(_weapons[0]);
        }

        if (Input.GetKeyDown("2"))
        {
            SwitchWeapon(_weapons[1]);
        }

        if (Input.GetKeyDown("3"))
        {
            SwitchWeapon(_weapons[2]);
        }
    }

    private void SwitchWeapon(Weapon newWeapon)
    {
        foreach (Weapon weapon in _weapons)
        {
            if (weapon == newWeapon) //Почему is не работает так и не понял
            {
                weapon.gameObject.SetActive(true);
                _shooter.SetupWeapon(weapon);
            }
            else
                weapon.gameObject.SetActive(false);
        }
    }
}
