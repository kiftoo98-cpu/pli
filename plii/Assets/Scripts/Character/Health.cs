using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 5;

    [SerializeField] private int _currentHealth;

    public Action OnDeath;
    public Action<int, int> OnDamaged;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void ChangeHealth(int value)
    {
        _currentHealth += value;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        if (_currentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
        OnDamaged?.Invoke(_currentHealth,_maxHealth);
    }

    
}
