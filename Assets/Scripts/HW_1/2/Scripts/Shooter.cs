using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Weapon _weapon;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _weapon.Shoot();
        }
    }

    public void SetupWeapon(Weapon weapon) 
    { 
        _weapon = weapon;
    }

}
