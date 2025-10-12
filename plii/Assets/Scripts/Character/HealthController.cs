using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private Health _health;
    private HealthView _healthView;
    
    void Start()
    {
        _health.OnDamaged += OnHealthChanged;
        _health.OnDeath += PlayerDestroy;
    }

    private void PlayerDestroy()
    {
        Destroy(gameObject);
    }

    private void OnHealthChanged(int newHealth, int maxhelth)
    {
        _healthView.ChangeBar(newHealth,maxhelth);
    }
    private void OnDestroy()
    {
        _health.OnDamaged -= OnHealthChanged;
        _health.OnDeath -= PlayerDestroy;
    }


}
