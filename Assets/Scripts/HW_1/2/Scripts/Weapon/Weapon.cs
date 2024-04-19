using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Bullet _bullet;
    [SerializeField] private Transform _bulletPoint;

    //public abstract string WeaponName;
    //����� ���������� �������� ����� ��� ������, ����� ��� ����� � WeaponSwitcher ������� � �������
    //�� ����� ��� �������� �������. �������� �� ������)))

    protected int _ammo;

    public void Initialize(int ammo)
    {
        _ammo = ammo;
    }

    public abstract void Shoot(); // ��� ���� ����� ������� ���� ���� ����� �������� ��� ���������� � ��������
    protected virtual void CreateBullet()
    {
        var bullet = Instantiate(_bullet);
        bullet.transform.forward = _bullet.transform.forward;
        bullet.transform.position = _bulletPoint.transform.position;

        bullet.Launch();
    }

}
