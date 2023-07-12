using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField, Range(100,500)] private int damage = 150;
    private Vector3 _currentPos;
    private Vector3 _prevPos;
    private void Update()
    {
        _prevPos = _currentPos;
        _currentPos = transform.position;
        if(_currentPos == _prevPos)
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
