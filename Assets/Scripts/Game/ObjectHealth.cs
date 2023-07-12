using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour, IDamageable
{
    [SerializeField, Range(100, 1000)] private int maxHealth;
    private int _currentHealth;

    private void OnEnable()
    {
        _currentHealth = maxHealth;
    }

    protected int GetCurrentHealth()
    {
        return _currentHealth;
    }

    public void TakeDamage(int value)
    {
        _currentHealth -= value;
        Debug.Log(_currentHealth);
        if (_currentHealth <= 0)
        {
            if (!gameObject.TryGetComponent(out PlayerController playerController))
            {
                Destroy(gameObject);
            }
            else GameEvents.Instance.PlayerLose();

        }
    }
}
