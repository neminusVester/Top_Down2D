using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    private Transform _target;
    private Vector3 _offset = new Vector3(0f, 0f, -10f);

    public void Init(Transform newTarget)
    {
        _target = newTarget;
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        if (!_target) return;

        Vector3 targetPosition = _target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }
}
