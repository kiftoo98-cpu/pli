using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField] EnemyHealth _enemyHealth;
    [SerializeField] EnemyHealthView _enemyHealthView;

    void Start()
    {
        _enemyHealth = GetComponent<EnemyHealth>();
        _enemyHealthView = GetComponent<EnemyHealthView>();
        _enemyHealth.OnHealthChange += OnHealthChanged;
        _enemyHealth.OnDeath += EnemyDestroy;
    }

    private void OnHealthChanged(int _newHealth, int _maxHealth)
    {
        _enemyHealthView.ChangeBar(_newHealth, _maxHealth);
    }

    private void EnemyDestroy()
    {
        Destroy(_enemyHealth.gameObject);
    }

    private void OnDestroy()
    {
        _enemyHealth.OnHealthChange -= OnHealthChanged;
        _enemyHealth.OnDeath -= EnemyDestroy;
    }

}
