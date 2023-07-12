using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ArmedEnemyController : BaseEnemyController
{
    private float _speed = 2f;

    public override void Init(PlayerController player)
    {
        base.Init(player);
    }

    private void Update()
    {
        MoveToTarget(_speed);
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
