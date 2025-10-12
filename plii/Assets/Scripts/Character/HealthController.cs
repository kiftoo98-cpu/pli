using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private Health _health;
    private HealthView _healthView;
    
    void Start()
    {

        _health = GetComponent<Health>();
        _healthView = GetComponent<HealthView>();

        _health.OnDamaged += OnHealthChanged;
        _health.OnDeath += PlayerDestroy;
    }


    


    private void OnHealthChanged(int newHealth, int maxhelth)
    {
        _healthView.ChangeBar(newHealth,maxhelth);
    }


    private void PlayerDestroy()
    {
        Destroy(_health.gameObject);
    }


    private void OnDestroy()
    {
        _health.OnDamaged -= OnHealthChanged;
        _health.OnDeath -= PlayerDestroy;
    }


}
