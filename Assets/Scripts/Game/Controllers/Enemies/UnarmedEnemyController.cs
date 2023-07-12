using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnarmedEnemyController : BaseEnemyController
{
    [SerializeField, Range(100, 400)] private int _collisionDamage = 200;
    private float _speed = 2f;

    public override void Init(PlayerController player)
    {
        base.Init(player);

    }

    private void Update()
    {
        MoveToTarget(_speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeDamage(_collisionDamage);
        }
    }

    private void OnDestroy()
    {
        GameEvents.Instance.KillEnemy();
    }

    protected override void MoveToTarget(float speed)
    {
        base.MoveToTarget(speed);
    }
}
