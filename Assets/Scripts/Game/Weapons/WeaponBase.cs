using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    private Vector3 _bulletTargetPosition;
    private float _bulletForce = 10f;
    [SerializeField] private Projectile projectile;

    private void InstantiateBullet(Projectile bulletPrefub, Transform bulletSpawn, Vector3 projectileRotation, float bulletDistance)
    {
        var bullet = Instantiate(bulletPrefub);
        bullet.transform.position = bulletSpawn.position;
        bullet.transform.localEulerAngles = projectileRotation;
        _bulletTargetPosition = bulletSpawn.position - bulletSpawn.up * bulletDistance;
        StartCoroutine(MoveToTarget(_bulletForce, _bulletTargetPosition, bullet.gameObject));
    }

    private IEnumerator MoveToTarget(float speed, Vector3 targetPosition, GameObject bullet)
    {
        while (bullet != null && bullet.transform.position != targetPosition)
        {
            bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, targetPosition, speed * Time.deltaTime);
            yield return null;
        }
    }

    public virtual void Shoot(Transform bulletSpawn, Vector3 projectileRotation, float distance)
    {
        InstantiateBullet(projectile, bulletSpawn, projectileRotation, distance);
    }
}
