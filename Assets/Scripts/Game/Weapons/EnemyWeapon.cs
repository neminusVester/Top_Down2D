using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : WeaponBase
{
    private float _aimAngle;
    private float _bulletDistance = 20f;
    private Vector2 _aimDirection;
    private float _aimOffset = 270f;
    private float _deltaZ = 90;
    private float _nextFire = 0f;
    private float _delay = 1f;
    private bool _alreadyAttacked = false;

    private void Update()
    {
        SetAimDirection();
        CalculateAttackDelay();
        Shoot(this.transform, new Vector3(0f, 0f, _aimAngle + _deltaZ), _bulletDistance);
    }

    private void FixedUpdate()
    {
        Aiming();
    }

    private void SetAimDirection()
    {
        if (PlayerController.Instance != null)
        {
            _aimDirection = PlayerController.Instance.transform.position - transform.position;
            _aimAngle = Mathf.Atan2(_aimDirection.y, _aimDirection.x) * Mathf.Rad2Deg - _aimOffset;
        }
    }

    private void Aiming()
    {
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, _aimAngle);
        transform.rotation = targetRotation;
    }

    public override void Shoot(Transform newTransform, Vector3 projectileRot, float distance)
    {
        if (!_alreadyAttacked)
        {
            base.Shoot(newTransform, projectileRot, distance);
            _alreadyAttacked = true;
        }
    }

    private void CalculateAttackDelay()
    {
        _nextFire += Time.deltaTime;

        if (_alreadyAttacked && _nextFire >= _delay)
        {
            _nextFire = 0;
            _alreadyAttacked = false;
        }
    }
}
