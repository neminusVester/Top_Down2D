using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : WeaponBase
{
    private float _aimAngle;
    private float _bulletDistance = 10f;
    private Vector2 _aimDirection;
    [SerializeField] private float deltaZ = 90;

    private void Start()
    {
    }

    private void Update()
    {
        InputsUpdate();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(this.transform, new Vector3(0f, 0f, _aimAngle + deltaZ), _bulletDistance);
        }
    }

    private void FixedUpdate()
    {
        _aimAngle = Mathf.Atan2(_aimDirection.y, _aimDirection.x) * Mathf.Rad2Deg - 270f;
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, _aimAngle);
        transform.rotation = targetRotation;
    }

    private void InputsUpdate()
    {
        _aimDirection = PlayerController.Instance.InputController.GetMousePosition() - transform.position;
    }

    public override void Shoot(Transform newTransform, Vector3 projectileRot, float distance)
    {
        base.Shoot(newTransform, projectileRot, distance);
    }


}
