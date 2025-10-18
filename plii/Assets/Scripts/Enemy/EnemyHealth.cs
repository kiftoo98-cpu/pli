using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamagable
{
    [SerializeField] private int _enemyMaxHealth = 5;
    [SerializeField] private int _enemyCurrentHealth;

    public Action OnDeath;
    public Action<int, int> OnHealthChange;
    //private bool _canHeal;

    private void Awake()
    {
        _enemyCurrentHealth = _enemyMaxHealth;
    }

    private void Update()
    {
        //StartCoroutine(EnemyHealing());

        if (_enemyCurrentHealth > _enemyMaxHealth)
        {
            _enemyCurrentHealth = _enemyMaxHealth;
            //OnHealthChange?.Invoke(_enemyCurrentHealth, _enemyMaxHealth);
        }

        if (_enemyCurrentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    public void TakeDamage(int amount, Vector2 hitPoint, Vector2 hitNormal)
    {
        _enemyCurrentHealth -= amount;
        OnHealthChange?.Invoke(_enemyCurrentHealth, _enemyMaxHealth);
    }

    //private IEnumerator EnemyHealing()
    //{
    //    while (_enemyCurrentHealth < _enemyMaxHealth)
    //    {
    //        yield return new WaitForSeconds(5f);
    //        _enemyCurrentHealth += 1;
    //        OnHealthChange?.Invoke(_enemyCurrentHealth, _enemyMaxHealth);
    //    }

    //}

}
