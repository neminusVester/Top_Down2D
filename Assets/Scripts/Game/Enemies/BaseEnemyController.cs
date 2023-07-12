using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyController : MonoBehaviour
{
    protected PlayerController _player;
    private Transform _target;

    public virtual void Init(PlayerController player)
    {
        _player = player;
        _target = _player.transform;
    }

    protected virtual void MoveToTarget(float speed)
    {
        if (!_target) return;

        transform.position = Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
    }


}
